namespace ChainOfResponsibility
{
    public class ResultHandler : BaseHandler
    {
        public ResultHandler(IHandler next) : base(next)
        {
        }

        public override void Handle(RequestContext requestContext)
        {
            Console.WriteLine("ResultHandler.Handle() start");
            requestContext.Response.IsSuccessful = true;
            requestContext.Response.Data = "some value";
        }
    }
}