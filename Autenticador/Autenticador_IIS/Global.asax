<%@ Application Language="C#" %>
<%@ Import Namespace="Autenticador.BL.Quartz" %>
<script RunAt="server">

    protected void Application_BeginRequest(object sender, EventArgs e)
    {
        // Adiciona headers permitidos
        HttpContext.Current.Response.AddHeader("Access-Control-Allow-Origin", "*");
        if (HttpContext.Current.Request.HttpMethod == "OPTIONS")
        {
            HttpContext.Current.Response.AddHeader("Access-Control-Allow-Methods", "GET, POST, DELETE, PUT");
            HttpContext.Current.Response.AddHeader("Access-Control-Allow-Headers", "Content-Type, Accept");
            HttpContext.Current.Response.AddHeader("Access-Control-Allow-Headers", "integracao, Accept");
            HttpContext.Current.Response.AddHeader("Access-Control-Max-Age", "1728000");
            HttpContext.Current.Response.End();
        }

        IniciaQuartz();
    }
    private void IniciaQuartz()
    {
        Schendule.Instance.Start(typeof(JobPoint));
    }
</script>