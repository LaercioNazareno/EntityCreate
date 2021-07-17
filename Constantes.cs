namespace EntityCreate
{
    public static class Constantes
    {

        public const string NAME_ENTITY = "Produto";
        private const string PROJECT_NAME = "DDD_Dotnet";

        #region PATHS
        public const string PATH_ENTITY = "";
        public const string PATH_SAMPLES = "";
        public const string PATH_CONTEXT = "";
        public const string PATH_ENTITY_CONFIG = "";
        public const string PATH_REPOSITORY = "";
        public const string PATH_INTERFACE_REPOSITORY = "";
        public const string PATH_DTO = "";
        public const string PATH_MAPPER = "";
        public const string PATH_SERVICE = "";
        public const string PATH_INTERFACE_SERVICE = "";
        public const string PATH_INTERFACE_APP_SERVICE = "";
        public const string PATH_APP_SERVICE = "";
        #endregion

        #region NAMESPACES
        public static readonly string NAMESPACE_ENTITY = $"{PROJECT_NAME}.Domain.Entities";
        public static readonly string NAMESPACE_CONTEXT = $"{PROJECT_NAME}.Infra.Data.Contexto";
        public static readonly string NAMESPACE_ENTITY_CONFIG = $"{PROJECT_NAME}.Infra.Data.EntityConfig";
        public static readonly string NAMESPACE_REPOSITORY = $"{PROJECT_NAME}.Infra.Data.Repositories";
        public static readonly string NAMESPACE_INTERFACE_REPOSITORY = $"{PROJECT_NAME}.Domain.Interfaces.Repositories";
        public static readonly string NAMESPACE_DTO = $"{PROJECT_NAME}.Application.DTO";
        public static readonly string NAMESPACE_MAPPER = $"{PROJECT_NAME}.Application.AutoMapper";
        public static readonly string NAMESPACE_SERVICE = $"{PROJECT_NAME}.Domain.Services";
        public static readonly string NAMESPACE_INTERFACE_SERVICE = $"{PROJECT_NAME}.Domain.Interfaces.Services";
        public static readonly string NAMESPACE_INTERFACE_APP_SERVICE = $"{PROJECT_NAME}.Application.Interfaces";
        public static readonly string NAMESPACE_APP_SERVICE = $"{PROJECT_NAME}.Application.Service";

        #endregion

        #region TAGS
        public const string TAG_CLASS_NAME = "CLASSNAME";
        public const string TAG_NAME_SPACE = "NAMESPACE";
        public const string TAG_IMPORT_MODELS = "IMPORT_MODELS";
        public const string TAG_IMPORT_REPOSITORY = "IMPORT_REPOSITORY";
        public const string TAG_IMPORT_INTEFARCE_REPOSITORY = "IMPORT_INTERFACE_REPOSITORY";
        public const string TAG_IMPORT_INTERFACE_SERVICE = "IMPORT_INTERFACE_SERVICE";
        public const string TAG_IMPORT_INTERFACE_APP_SERVICE = "IMPORT_INTERFACE_APP_SERVICE";
        public const string TAG_IMPORT_APP_SERVICE = "IMPORT_APP_SERVICE";
        public const string TAG_ENTITY_TYPE = "ENTITY_TYPE";
        public const string TAG_IMPORT_CONTXT = "IMPORT_CONTXT";
        public const string TAG_IMPORT_DTO = "IMPORT_DTO";
        #endregion

        #region TYPES
        public const string ENTITY_TYPE = "Entity.txt";
        public const string ENTITY_BASE_TYPE = "EntityBase.txt";
        public const string CONTEXT_TYPE = "Context.txt";
        public const string ENTITY_CONFIG_TYPE = "EntityConfig.txt";
        public const string REPOSITORY_TYPE = "Repository.txt";
        public const string I_REPOSITORY_TYPE = "IRepository.txt";
        public const string REPOSITORY_BASE_TYPE = "RepositoryBase.txt";
        public const string I_REPOSITORY_BASE_TYPE = "IRepositoryBase.txt";
        public const string DTO_TYPE = "DTO.txt";
        public const string MAPPER_TYPE = "Mapper.txt";
        public const string SERVICE_BASE_TYPE = "ServiceBase.txt";
        public const string I_SERVICE_BASE_TYPE = "IServiceBase.txt";
        public const string I_APP_SERVICE_TYPE = "IAppService.txt";
        public const string APP_SERVICE_TYPE = "AppService.txt";
        public const string SERVICE_TYPE = "Service.txt";
        public const string I_SERVICE_TYPE = "IService.txt";
        public const string CUSTOM_MAPPER_TYPE = "CustomDtoMapper.txt";
        #endregion
    }
}
