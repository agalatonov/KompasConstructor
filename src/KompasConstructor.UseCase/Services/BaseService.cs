
using KompasAPI7;

namespace KompasConstructor.UseCase.Services
{
    public class BaseService
    {
        protected static IApplication _kompasInstance;
        private const string _kompasProgID = "Kompas.Application.7";

        public BaseService() 
        {
            try
            {
                Type t = Type.GetType(_kompasProgID);
                var _kompasInstance = (IApplication)Activator.CreateInstance(t);
                _kompasInstance.Visible = true;
            }
            catch (Exception ex)
            {

            }
        }
    }
}
