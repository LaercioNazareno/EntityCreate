using System.IO;

namespace EntityCreate
{
    public static class Constantes
    {
        public static string NAME_ENTITY = "";
        public static string GetProjectName()
        {
            DirectoryInfo dir_info = new DirectoryInfo("createAmbiente.sh");
            string path_base = dir_info.Parent.Parent.Name;
            return path_base;
        }
        #region PATHS
        public static string PATH_ENTITY = "../3-Domain/" + GetProjectName() + ".Domain/Entities/";
        public static string PATH_SAMPLES = "../EntityCreate/classSamples/";
        public static string PATH_CONTEXT = "../4-Infra/4.1-Data/" + GetProjectName() + ".Infra.Data/Context/";
        public static string PATH_ENTITY_CONFIG = "../4-Infra/4.1-Data/" + GetProjectName() + ".Infra.Data/EntityConfig/";
        public static string PATH_REPOSITORY = "../4-Infra/4.1-Data/" + GetProjectName() + ".Infra.Data/Repositories/";
        public static string PATH_INTERFACE_REPOSITORY = "../3-Domain/" + GetProjectName() + ".Domain/Interfaces/Repositories/";
        public static string PATH_DTO = "../2-Application/" + GetProjectName() + ".Application/DTO/";
        public static string PATH_MAPPER = "../2-Application/" + GetProjectName() + ".Application/Mapper/";
        public static string PATH_SERVICE = "../3-Domain/" + GetProjectName() + ".Domain/Services/";
        public static string PATH_INTERFACE_SERVICE = "../3-Domain/" + GetProjectName() + ".Domain/Interfaces/Services/";
        public static string PATH_INTERFACE_APP_SERVICE = "../2-Application/" + GetProjectName() + ".Application/Interfaces/";
        public static string PATH_APP_SERVICE = "../2-Application/" + GetProjectName() + ".Application/AppServices/";
        public static string PATH_IOC = "../4-Infra/4.2-CrossCutting/" + GetProjectName() + ".Infra.Ioc/";
        #endregion


        #region NAMESPACES
        public static readonly string NAMESPACE_ENTITY = $"{GetProjectName()}.Domain.Entities";
        public static readonly string NAMESPACE_CONTEXT = $"{GetProjectName()}.Infra.Data.Contexto";
        public static readonly string NAMESPACE_ENTITY_CONFIG = $"{GetProjectName()}.Infra.Data.EntityConfig";
        public static readonly string NAMESPACE_REPOSITORY = $"{GetProjectName()}.Infra.Data.Repositories";
        public static readonly string NAMESPACE_INTERFACE_REPOSITORY = $"{GetProjectName()}.Domain.Interfaces.Repositories";
        public static readonly string NAMESPACE_DTO = $"{GetProjectName()}.Application.DTO";
        public static readonly string NAMESPACE_MAPPER = $"{GetProjectName()}.Application.AutoMapper";
        public static readonly string NAMESPACE_SERVICE = $"{GetProjectName()}.Domain.Services";
        public static readonly string NAMESPACE_INTERFACE_SERVICE = $"{GetProjectName()}.Domain.Interfaces.Services";
        public static readonly string NAMESPACE_INTERFACE_APP_SERVICE = $"{GetProjectName()}.Application.Interfaces";
        public static readonly string NAMESPACE_APP_SERVICE = $"{GetProjectName()}.Application.AppServices";
        public static readonly string NAMESPACE_IOC = $"{GetProjectName()}.Infra.CrossCutting.IoC";

        #endregion

        #region TAGS
        public static string TAG_CLASS_NAME = "CLASSNAME";
        public static string TAG_NAME_SPACE = "NAMESPACE";
        public static string TAG_IMPORT_MODELS = "IMPORT_MODELS";
        public static string TAG_IMPORT_REPOSITORY = "IMPORT_REPOSITORY";
        public static string TAG_IMPORT_INTEFARCE_REPOSITORY = "IMPORT_INTERFACE_REPOSITORY";
        public static string TAG_IMPORT_INTERFACE_SERVICE = "IMPORT_INTERFACE_SERVICE";
        public static string TAG_IMPORT_SERVICE = "IMPORT_SERVICE";
        public static string TAG_IMPORT_INTERFACE_APP_SERVICE = "IMPORT_INTERFACE_APP_SERVICE";
        public static string TAG_IMPORT_APP_SERVICE = "IMPORT_APP_SERVICE";
        public static string TAG_ENTITY_TYPE = "ENTITY_TYPE";
        public static string TAG_IMPORT_CONTXT = "IMPORT_CONTXT";
        public static string TAG_IMPORT_DTO = "IMPORT_DTO";
        #endregion

        #region TYPES
        public static string ENTITY_TYPE = "Entity.txt";
        public static string ENTITY_BASE_TYPE = "EntityBase.txt";
        public static string CONTEXT_TYPE = "Context.txt";
        public static string ENTITY_CONFIG_TYPE = "EntityConfig.txt";
        public static string REPOSITORY_TYPE = "Repository.txt";
        public static string I_REPOSITORY_TYPE = "IRepository.txt";
        public static string REPOSITORY_BASE_TYPE = "RepositoryBase.txt";
        public static string I_REPOSITORY_BASE_TYPE = "IRepositoryBase.txt";
        public static string DTO_TYPE = "DTO.txt";
        public static string MAPPER_TYPE = "Mapper.txt";
        public static string SERVICE_BASE_TYPE = "ServiceBase.txt";
        public static string I_SERVICE_BASE_TYPE = "IServiceBase.txt";
        public static string I_APP_SERVICE_TYPE = "IAppService.txt";
        public static string APP_SERVICE_TYPE = "AppService.txt";
        public static string SERVICE_TYPE = "Service.txt";
        public static string I_SERVICE_TYPE = "IService.txt";
        public static string CUSTOM_MAPPER_TYPE = "CustomDtoMapper.txt";
        public static string IOC_TYPE = "DependencyInjection.txt";
        public static string APP_SERVICE_BASE_TYPE = "AppServiceBase.txt";
        public static string I_APP_SERVICE_BASE_TYPE = "IAppServiceBase.txt";
        #endregion
    }
}
