using Microsoft.VisualBasic;
using System.Collections.Generic;

namespace EntityCreate
{
    public class FileCreate
    {
        public string path { get; set; }
        public string type { get; set; }
        public string nameFile { get; set; }
        public Dictionary<string, string> dictionary { get; set; }

        public static FileCreate EntityBase()
        {
            return new FileCreate()
            {
                path = Constantes.PATH_ENTITY,
                type = Constantes.ENTITY_BASE_TYPE,
                nameFile = "EntityBase",
                dictionary = new Dictionary<string, string>()
                {
                    {Constantes.TAG_NAME_SPACE, Constantes.NAMESPACE_ENTITY}
                }
            };
        }
        public static FileCreate Context()
        {
            var name = Constantes.GetProjectName()+"Context";
            return new FileCreate()
            {
                path = Constantes.PATH_CONTEXT,
                type = Constantes.CONTEXT_TYPE,
                nameFile = name,
                dictionary = new Dictionary<string, string>()
                {
                    {Constantes.TAG_CLASS_NAME, name},
                    {Constantes.TAG_NAME_SPACE, Constantes.NAMESPACE_CONTEXT}
                }
            };
        }
        public static FileCreate EntityConfig(string nameEntity)
        {
            var name = $"{nameEntity}Configuration";
            return new FileCreate()
            {
                path = Constantes.PATH_ENTITY_CONFIG,
                type = Constantes.ENTITY_CONFIG_TYPE,
                nameFile = name,
                dictionary = new Dictionary<string, string>()
                {
                    {Constantes.TAG_IMPORT_MODELS, Constantes.NAMESPACE_ENTITY},
                    {Constantes.TAG_NAME_SPACE, Constantes.NAMESPACE_ENTITY_CONFIG},
                    {Constantes.TAG_CLASS_NAME, name},
                    {Constantes.TAG_ENTITY_TYPE, nameEntity}
                }
            };
        }
        public static FileCreate Repository(string nameEntity)
        {
            var name = $"{nameEntity}Repository";
            return new FileCreate()
            {
                path = Constantes.PATH_REPOSITORY,
                type = Constantes.REPOSITORY_TYPE,
                nameFile = name,
                dictionary = new Dictionary<string, string>()
                {
                    {Constantes.TAG_IMPORT_MODELS, Constantes.NAMESPACE_ENTITY},
                    {Constantes.TAG_CLASS_NAME, name},
                    {Constantes.TAG_ENTITY_TYPE, nameEntity},
                    {Constantes.TAG_NAME_SPACE, Constantes.NAMESPACE_REPOSITORY},
                    {Constantes.TAG_IMPORT_INTEFARCE_REPOSITORY, Constantes.NAMESPACE_INTERFACE_REPOSITORY},
                    {Constantes.TAG_IMPORT_CONTXT, Constantes.NAMESPACE_CONTEXT},
                    {Constantes.TAG_CONTEXT, Constantes.CONTEXT}
                }
            };
        }
        public static FileCreate RepoitoryBase()
        {
            return new FileCreate()
            {
                path = Constantes.PATH_REPOSITORY,
                type = Constantes.REPOSITORY_BASE_TYPE,
                nameFile = $"RepositoryBase",
                dictionary = new Dictionary<string, string>()
                {
                    {Constantes.TAG_IMPORT_MODELS, Constantes.NAMESPACE_ENTITY},
                    {Constantes.TAG_NAME_SPACE, Constantes.NAMESPACE_REPOSITORY},
                    {Constantes.TAG_IMPORT_REPOSITORY, Constantes.NAMESPACE_INTERFACE_REPOSITORY},
                    {Constantes.TAG_IMPORT_CONTXT, Constantes.NAMESPACE_CONTEXT},
                    {Constantes.TAG_IMPORT_INTEFARCE_REPOSITORY, Constantes.NAMESPACE_INTERFACE_REPOSITORY},
                    {Constantes.TAG_CONTEXT, Constantes.CONTEXT}
                }
            };
        }
        public static FileCreate IRepository(string nameEntity)
        {
            return new FileCreate()
            {
                path = Constantes.PATH_INTERFACE_REPOSITORY,
                type = Constantes.I_REPOSITORY_TYPE,
                nameFile = $"I{nameEntity}Repository",
                dictionary = new Dictionary<string, string>()
                {
                    {Constantes.TAG_IMPORT_MODELS, Constantes.NAMESPACE_ENTITY},
                    {Constantes.TAG_IMPORT_REPOSITORY, Constantes.NAMESPACE_INTERFACE_REPOSITORY},
                    {Constantes.TAG_ENTITY_TYPE, nameEntity},
                    {Constantes.TAG_NAME_SPACE, Constantes.NAMESPACE_INTERFACE_REPOSITORY}
                }
            };
        }
        public static FileCreate IRepositoryBase()
        {
            return new FileCreate()
            {
                path = Constantes.PATH_INTERFACE_REPOSITORY,
                type = Constantes.I_REPOSITORY_BASE_TYPE,
                nameFile = $"IRepositoryBase",
                dictionary = new Dictionary<string, string>()
                {
                    {Constantes.TAG_NAME_SPACE, Constantes.NAMESPACE_INTERFACE_REPOSITORY}
                }
            };
        }
        public static FileCreate Dto(string nameEntity)
        {
            return new FileCreate()
            {
                path = Constantes.PATH_DTO,
                type = Constantes.DTO_TYPE,
                nameFile = $"{nameEntity}DTO",
                dictionary = new Dictionary<string, string>()
                {
                    {Constantes.TAG_CLASS_NAME, nameEntity},
                    {Constantes.TAG_NAME_SPACE, Constantes.NAMESPACE_DTO}
                }
            };
        }
        public static FileCreate ObjectMapper()
        {
            return new FileCreate()
            {
                path = Constantes.PATH_MAPPER,
                type = Constantes.MAPPER_TYPE,
                nameFile = "ObjectMapper",
                dictionary = new Dictionary<string, string>()
                {
                    {Constantes.TAG_NAME_SPACE, Constantes.NAMESPACE_MAPPER}
                }
            };
        }
        public static FileCreate ServiceBase()
        {
            return new FileCreate()
            {
                path = Constantes.PATH_SERVICE,
                type = Constantes.SERVICE_BASE_TYPE,
                nameFile = $"ServiceBase",
                dictionary = new Dictionary<string, string>()
                {
                    {Constantes.TAG_IMPORT_INTEFARCE_REPOSITORY, Constantes.NAMESPACE_INTERFACE_REPOSITORY},
                    {Constantes.TAG_IMPORT_INTERFACE_SERVICE, Constantes.NAMESPACE_INTERFACE_SERVICE},
                    {Constantes.TAG_NAME_SPACE, Constantes.NAMESPACE_SERVICE}
                }
            };
        }
        public static FileCreate IServiceBase()
        {
            return new FileCreate()
            {
                path = Constantes.PATH_INTERFACE_SERVICE,
                type = Constantes.I_SERVICE_BASE_TYPE,
                nameFile = $"IServiceBase",
                dictionary = new Dictionary<string, string>()
                {
                    {Constantes.TAG_NAME_SPACE, Constantes.NAMESPACE_INTERFACE_SERVICE}
                }
            };
        }
        public static FileCreate IAppService(string nameEntity)
        {
            var name = $"I{nameEntity}AppService";
            return new FileCreate()
            {
                path = Constantes.PATH_INTERFACE_APP_SERVICE,
                type = Constantes.I_APP_SERVICE_TYPE,
                nameFile = name,
                dictionary = new Dictionary<string, string>()
                {
                    {Constantes.TAG_NAME_SPACE, Constantes.NAMESPACE_INTERFACE_APP_SERVICE},
                    {Constantes.TAG_CLASS_NAME, name},
                    {Constantes.TAG_ENTITY_TYPE, nameEntity}
                }
            };
        }
         public static FileCreate IAppServiceBase()
        {
            var name = "IAppServiceBase";
            return new FileCreate()
            {
                path = Constantes.PATH_INTERFACE_APP_SERVICE,
                type = Constantes.I_APP_SERVICE_BASE_TYPE,
                nameFile = name,
                dictionary = new Dictionary<string, string>()
                {
                    {Constantes.TAG_NAME_SPACE, Constantes.NAMESPACE_INTERFACE_APP_SERVICE},
                    {Constantes.TAG_CLASS_NAME, name}
                
                }
            };
        }
        public static FileCreate AppService(string nameEntity)
        {
            var name = $"{nameEntity}AppService";
            return new FileCreate()
            {
                path = Constantes.PATH_APP_SERVICE,
                type = Constantes.APP_SERVICE_TYPE,
                nameFile = name,
                dictionary = new Dictionary<string, string>()
                {
                    {Constantes.TAG_NAME_SPACE, Constantes.NAMESPACE_APP_SERVICE},
                    {Constantes.TAG_CLASS_NAME, name},
                    {Constantes.TAG_IMPORT_INTERFACE_APP_SERVICE, Constantes.NAMESPACE_INTERFACE_APP_SERVICE},
                    {Constantes.TAG_IMPORT_INTERFACE_SERVICE, Constantes.NAMESPACE_INTERFACE_SERVICE},
                    {Constantes.TAG_ENTITY_TYPE, nameEntity}
                }
            };
        }
        public static FileCreate AppServiceBase()
        {
            var name = "AppServiceBase";
            return new FileCreate()
            {
                path = Constantes.PATH_APP_SERVICE,
                type = Constantes.APP_SERVICE_BASE_TYPE,
                nameFile = name,
                dictionary = new Dictionary<string, string>()
                {
                    {Constantes.TAG_NAME_SPACE, Constantes.NAMESPACE_APP_SERVICE},
                    {Constantes.TAG_CLASS_NAME, name},
                    {Constantes.TAG_IMPORT_INTERFACE_APP_SERVICE, Constantes.NAMESPACE_INTERFACE_APP_SERVICE},
                    {Constantes.TAG_IMPORT_INTERFACE_SERVICE, Constantes.NAMESPACE_INTERFACE_SERVICE}
                }
            };
        }
        public static FileCreate IService(string nameEntity)
        {
            var name = $"I{nameEntity}Service";
            return new FileCreate()
            {
                path = Constantes.PATH_INTERFACE_SERVICE,
                type = Constantes.I_SERVICE_TYPE,
                nameFile = name,
                dictionary = new Dictionary<string, string>()
                {
                    {Constantes.TAG_NAME_SPACE, Constantes.NAMESPACE_INTERFACE_SERVICE},
                    {Constantes.TAG_CLASS_NAME, name},
                    {Constantes.TAG_ENTITY_TYPE, nameEntity},
                    {Constantes.TAG_IMPORT_MODELS, Constantes.NAMESPACE_ENTITY}
                }
            };
        }
        public static FileCreate Service(string nameEntity)
        {
            var name = $"{nameEntity}Service";
            return new FileCreate()
            {
                path = Constantes.PATH_SERVICE,
                type = Constantes.SERVICE_TYPE,
                nameFile = name,
                dictionary = new Dictionary<string, string>()
                {
                    {Constantes.TAG_IMPORT_INTEFARCE_REPOSITORY, Constantes.NAMESPACE_INTERFACE_REPOSITORY},
                    {Constantes.TAG_IMPORT_INTERFACE_SERVICE, Constantes.NAMESPACE_INTERFACE_SERVICE},
                    {Constantes.TAG_NAME_SPACE, Constantes.NAMESPACE_SERVICE},
                    {Constantes.TAG_ENTITY_TYPE, nameEntity},
                    {Constantes.TAG_IMPORT_MODELS, Constantes.NAMESPACE_ENTITY},
                    {Constantes.TAG_CLASS_NAME, name}
                }
            };
        }
        public static FileCreate CustomMapper()
        {
            var name = "CustomDtoMapper";
            return new FileCreate()
            {
                path = Constantes.PATH_MAPPER,
                type = Constantes.CUSTOM_MAPPER_TYPE,
                nameFile = name,
                dictionary = new Dictionary<string, string>()
                {
                    {Constantes.TAG_NAME_SPACE, Constantes.NAMESPACE_MAPPER},
                    {Constantes.TAG_IMPORT_MODELS, Constantes.NAMESPACE_ENTITY}
                }
            };
        }
        public static FileCreate Entity(string nameEntity)
        {
            return new FileCreate()
            {
                path = Constantes.PATH_ENTITY,
                type = Constantes.ENTITY_TYPE,
                nameFile = nameEntity,
                dictionary = new Dictionary<string, string>()
                {
                    {Constantes.TAG_CLASS_NAME, nameEntity},
                    {Constantes.TAG_NAME_SPACE, Constantes.NAMESPACE_ENTITY}
                }
            };
        }
        public static FileCreate DependencyInjection()
        {
            return new FileCreate()
            {
                path = Constantes.PATH_IOC,
                type = Constantes.IOC_TYPE,
                nameFile = "DependencyInjection",
                dictionary = new Dictionary<string, string>()
                {
                    {Constantes.TAG_IMPORT_INTEFARCE_REPOSITORY, Constantes.NAMESPACE_INTERFACE_REPOSITORY},
                    {Constantes.TAG_IMPORT_REPOSITORY, Constantes.NAMESPACE_REPOSITORY},
                    {Constantes.TAG_IMPORT_INTERFACE_SERVICE, Constantes.NAMESPACE_INTERFACE_SERVICE},
                    {Constantes.TAG_IMPORT_SERVICE, Constantes.NAMESPACE_SERVICE},
                    {Constantes.TAG_NAME_SPACE, Constantes.NAMESPACE_IOC},
                    {Constantes.TAG_IMPORT_APP_SERVICE, Constantes.NAMESPACE_APP_SERVICE},
                    {Constantes.TAG_IMPORT_INTERFACE_APP_SERVICE, Constantes.NAMESPACE_INTERFACE_APP_SERVICE},
                    {Constantes.TAG_IMPORT_CONTXT, Constantes.NAMESPACE_CONTEXT},
                    {Constantes.TAG_CONTEXT, Constantes.CONTEXT}
                }
            };
        }
    }
}