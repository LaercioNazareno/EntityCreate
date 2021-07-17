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
                    {Constantes.TAG_CLASS_NAME, Constantes.NAME_ENTITY},
                    {Constantes.TAG_NAME_SPACE, Constantes.NAMESPACE_ENTITY}
                }
            };
        }
        public static FileCreate Context()
        {
            return new FileCreate()
            {
                path = Constantes.PATH_CONTEXT,
                type = Constantes.CONTEXT_TYPE,
                nameFile = "Context",
                dictionary = new Dictionary<string, string>()
                {
                    {Constantes.TAG_NAME_SPACE, Constantes.NAMESPACE_CONTEXT}
                }
            };
        }
        public static FileCreate EntityConfig()
        {
            var name = $"{Constantes.NAME_ENTITY}Configuration";
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
                    {Constantes.TAG_ENTITY_TYPE, Constantes.NAME_ENTITY}
                }
            };
        }
        public static FileCreate Repository()
        {
            var name = $"{Constantes.NAME_ENTITY}Repository";
            return new FileCreate()
            {
                path = Constantes.PATH_REPOSITORY,
                type = Constantes.REPOSITORY_TYPE,
                nameFile = name,
                dictionary = new Dictionary<string, string>()
                {
                    {Constantes.TAG_IMPORT_MODELS, Constantes.NAMESPACE_ENTITY},
                    {Constantes.TAG_CLASS_NAME, name},
                    {Constantes.TAG_ENTITY_TYPE, Constantes.NAME_ENTITY},
                    {Constantes.TAG_NAME_SPACE, Constantes.NAMESPACE_REPOSITORY},
                    {Constantes.TAG_IMPORT_INTEFARCE_REPOSITORY, Constantes.NAMESPACE_INTERFACE_REPOSITORY},
                    {Constantes.TAG_IMPORT_CONTXT, Constantes.NAMESPACE_CONTEXT}
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
                dictionary  = new Dictionary<string, string>()
                {
                    {Constantes.TAG_IMPORT_MODELS, Constantes.NAMESPACE_ENTITY},
                    {Constantes.TAG_NAME_SPACE, Constantes.NAMESPACE_REPOSITORY},
                    {Constantes.TAG_IMPORT_REPOSITORY, Constantes.NAMESPACE_INTERFACE_REPOSITORY},
                    {Constantes.TAG_IMPORT_CONTXT, Constantes.NAMESPACE_CONTEXT},
                    {Constantes.TAG_IMPORT_INTEFARCE_REPOSITORY, Constantes.NAMESPACE_INTERFACE_REPOSITORY}
                }
            };
        }
        public static FileCreate IRepository()
        {
            return new FileCreate()
            {
                path = Constantes.PATH_INTERFACE_REPOSITORY,
                type = Constantes.I_REPOSITORY_TYPE,
                nameFile = $"I{Constantes.NAME_ENTITY}Repository",
                dictionary = new Dictionary<string, string>()
                {
                    {Constantes.TAG_IMPORT_MODELS, Constantes.NAMESPACE_ENTITY},
                    {Constantes.TAG_IMPORT_REPOSITORY, Constantes.NAMESPACE_INTERFACE_REPOSITORY},
                    {Constantes.TAG_ENTITY_TYPE, Constantes.NAME_ENTITY},
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
        public static FileCreate Dto()
        {
            return new FileCreate()
            {
                path = Constantes.PATH_DTO,
                type = Constantes.DTO_TYPE,
                nameFile = $"{Constantes.NAME_ENTITY}DTO",
                dictionary = new Dictionary<string, string>()
                {
                    {Constantes.TAG_CLASS_NAME, Constantes.NAME_ENTITY},
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
        public static FileCreate IAppService()
        {
            var name = $"I{Constantes.NAME_ENTITY}AppService";
            return new FileCreate()
            {
                path = Constantes.PATH_INTERFACE_APP_SERVICE,
                type = Constantes.I_APP_SERVICE_TYPE,
                nameFile = name,
                dictionary = new Dictionary<string, string>()
                {
                    {Constantes.TAG_NAME_SPACE, Constantes.NAMESPACE_INTERFACE_APP_SERVICE},
                    {Constantes.TAG_CLASS_NAME, name}
                }
            };
        }
        public static FileCreate AppService()
        {
            var name = $"{Constantes.NAME_ENTITY}AppService";
            return new FileCreate()
            {
                path = Constantes.PATH_APP_SERVICE,
                type = Constantes.APP_SERVICE_TYPE,
                nameFile = name,
                dictionary = new Dictionary<string, string>()
                {
                    {Constantes.TAG_NAME_SPACE, Constantes.NAMESPACE_APP_SERVICE},
                    {Constantes.TAG_CLASS_NAME, name},
                    {Constantes.TAG_IMPORT_INTERFACE_APP_SERVICE, Constantes.NAMESPACE_INTERFACE_APP_SERVICE}
                }
            };
        }
        public static FileCreate IService()
        {
            var name = $"I{Constantes.NAME_ENTITY}Service";
            return new FileCreate()
            {
                path = Constantes.PATH_INTERFACE_SERVICE,
                type = Constantes.I_SERVICE_TYPE,
                nameFile = name,
                dictionary = new Dictionary<string, string>()
                {
                    {Constantes.TAG_NAME_SPACE, Constantes.NAMESPACE_INTERFACE_SERVICE},
                    {Constantes.TAG_CLASS_NAME, name},
                    {Constantes.TAG_ENTITY_TYPE, Constantes.NAME_ENTITY},
                    {Constantes.TAG_IMPORT_MODELS, Constantes.NAMESPACE_ENTITY}
                }
            };
        }
        public static FileCreate Service()
        {
            var name = $"{Constantes.NAME_ENTITY}Service";
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
                    {Constantes.TAG_ENTITY_TYPE, Constantes.NAME_ENTITY},
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
                    {Constantes.TAG_IMPORT_DTO, Constantes.NAMESPACE_DTO}
                }
            };
        }
        public static FileCreate Entity()
        {
            return new FileCreate()
            {
                path = Constantes.PATH_ENTITY,
                type = Constantes.ENTITY_TYPE,
                nameFile = Constantes.NAME_ENTITY,
                dictionary = new Dictionary<string, string>()
                {
                    {Constantes.TAG_CLASS_NAME, Constantes.NAME_ENTITY},
                    {Constantes.TAG_NAME_SPACE, Constantes.NAMESPACE_ENTITY}
                }
            };
        }
    }
}