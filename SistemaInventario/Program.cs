namespace SistemaInventario
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            // CAMBIA "new SistemaInventario()" POR "new FormPrincipal()"
            Application.Run(new FormPrincipal());
        }
    }
}