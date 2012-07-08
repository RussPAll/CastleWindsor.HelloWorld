using CastleWindsor.HelloWorld.Services;

namespace CastleWindsor.HelloWorld.Web.AppCode
{
    public class DefaultPresenter
    {
        private IHelloWorldRepository _repository;

        public DefaultPresenter(IHelloWorldRepository repository)
        {
            _repository = repository;
        }

        public string GetMessage()
        {
            return _repository.Message;
        }
    }
}