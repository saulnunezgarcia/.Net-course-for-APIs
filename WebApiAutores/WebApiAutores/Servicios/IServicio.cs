namespace WebApiAutores.Servicios
{
    public interface IServicio
    {
        Guid obtenerScoped();
        Guid obtenerSingleton();
        Guid obtenerTransient();
        void RealizarTarea();
    }

    public class ServicioA : IServicio
    {
        private readonly ILogger<ServicioA> logger;
        private readonly ServicioTransient servicioTransient;
        private readonly ServicioScoped servicioScoped;
        private readonly ServicioSingleton servicioSingleton;

        public ServicioA(ILogger<ServicioA> logger, ServicioTransient servicioTransient, 
            ServicioScoped servicioScoped, ServicioSingleton servicioSingleton)
        {
            this.logger = logger;
            this.servicioTransient = servicioTransient;
            this.servicioScoped = servicioScoped;
            this.servicioSingleton = servicioSingleton;
        }

        public Guid obtenerTransient() { return servicioTransient.Guid; }
        public Guid obtenerScoped() { return servicioScoped.Guid; }
        public Guid obtenerSingleton() { return servicioSingleton.Guid; }
        public void RealizarTarea()
        {
            throw new NotImplementedException();
        }
    }

    public class ServicioB : IServicio
    {
        public Guid obtenerScoped()
        {
            throw new NotImplementedException();
        }

        public Guid obtenerSingleton()
        {
            throw new NotImplementedException();
        }

        public Guid obtenerTransient()
        {
            throw new NotImplementedException();
        }

        public void RealizarTarea()
        {
            throw new NotImplementedException();
        }
    }

    public class ServicioTransient
    {
        public Guid Guid = Guid.NewGuid();
    }

    public class ServicioScoped
    {
        public Guid Guid = Guid.NewGuid();
    }

    public class ServicioSingleton
    {
        public Guid Guid = Guid.NewGuid();
    }
}
