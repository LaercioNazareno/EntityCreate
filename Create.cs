using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace EntityCreate
{
    public class Create
    {
        public static void CreateEntity()
        {
            var nameEntity = "client";
            var fileCreateList = GetFilesEntity(nameEntity);
            CreateFiles(fileCreateList);
        }

        public static void CreateUserCase()
        {
            var fileCreateList = GetFilesUserCase();

            var nameEntities = new List<string>()
            {
                "Client"
            };
            foreach (var entity in nameEntities)
            {
                fileCreateList.AddRange(GetFilesEntity(entity));
            }
            CreateFiles(fileCreateList);
        }

        private static List<FileCreate> GetFilesUserCase()
        {            
            var fileCreateList = new List<FileCreate>();
            var userCaseName = "Client";
            fileCreateList.Add(FileCreate.AppService(userCaseName));
            fileCreateList.Add(FileCreate.IAppService(userCaseName));

            return fileCreateList;
        }

        public static void CreateStruct()
        {
            var fileCreateList = GetFilesStruct();
            CreateFiles(fileCreateList);
        }
        private static void CreateFiles(List<FileCreate> fileCreateList)
        {
            foreach (var fileCreate in fileCreateList)
            {
                create(fileCreate);
            }
        }
        private static List<FileCreate> GetFilesEntity(string nameEntity)
        {
            var fileCreateList = new List<FileCreate>();

            fileCreateList.Add(FileCreate.Entity(nameEntity));
            fileCreateList.Add(FileCreate.EntityConfig(nameEntity));
            fileCreateList.Add(FileCreate.IRepository(nameEntity));
            fileCreateList.Add(FileCreate.Repository(nameEntity));
            fileCreateList.Add(FileCreate.Dto(nameEntity));
            fileCreateList.Add(FileCreate.IService(nameEntity));
            fileCreateList.Add(FileCreate.Service(nameEntity));
            
            return fileCreateList;
        }
        private static List<FileCreate> GetFilesStruct()
        {
            var fileCreateList = new List<FileCreate>();

            fileCreateList.Add(FileCreate.EntityBase());
            fileCreateList.Add(FileCreate.Context());
            fileCreateList.Add(FileCreate.RepoitoryBase());
            fileCreateList.Add(FileCreate.IRepositoryBase());
            fileCreateList.Add(FileCreate.ObjectMapper());
            fileCreateList.Add(FileCreate.CustomMapper());
            fileCreateList.Add(FileCreate.ServiceBase());
            fileCreateList.Add(FileCreate.IServiceBase());
            fileCreateList.Add(FileCreate.DependencyInjection());
            fileCreateList.Add(FileCreate.IAppServiceBase());
            fileCreateList.Add(FileCreate.AppServiceBase());
            
            return fileCreateList;
        }
        private static void create(FileCreate file)
        {
            var body = GetBody(file.dictionary, file.type);
            file.path = file.path + file.nameFile + ".cs";

            CreateFile(file.path, body);
        }
        private static string GetBody(Dictionary<string, string> tags, string type)
        {
            var body = File.ReadAllText(Constantes.PATH_SAMPLES + type);
            foreach (var tag in tags)
            {
                body = ReplaceTagInBodyByText(body, tag.Key, tag.Value);
            }
            return body;
        }
        private static string ReplaceTagInBodyByText(string body, string tag, string text)
        {
            return body.Replace(tag, text);
        }
        private static void CreateFile(string path, string body)
        {
            using (StreamWriter outputFile = new StreamWriter(path))
                outputFile.WriteLine(body);
        }
    }
}