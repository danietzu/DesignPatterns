namespace ChainOfResponsibility
{
    public abstract class Handler
    {
        private readonly Handler _next;

        public Handler(Handler next)
        {
            _next = next;
        }

        public void Handle(HttpRequest httpRequest)
        {
            if (DoHandle(httpRequest))
                return;

            if (_next != null)
                _next.Handle(httpRequest);
        }

        public abstract bool DoHandle(HttpRequest httpRequest);
    }
}