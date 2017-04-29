using System;
using System.Web.Mvc;

namespace ProjetoLivraria.MVC.Gentelella.Helpers
{
    public static class DataHoraExtensions
    {

        public static string CarregarMensagemTempoPassado(this HtmlHelper htmlHelper, DateTime data)
        {
            var tempoPassado = data.ToString();
            TimeSpan diferenca = DateTime.Now - data;
            
            if(diferenca.TotalMinutes < 60)
                tempoPassado = string.Format("{0:N0} minuto(s) atrás", diferenca.TotalMinutes);
            else if(diferenca.TotalHours < 24)
                tempoPassado = string.Format("{0:N0} hora(s) atrás", diferenca.TotalHours);
            else if(diferenca.TotalDays < 30)
                tempoPassado = string.Format("{0:N0} dia(s) atrás", diferenca.TotalDays);

            return tempoPassado;
        }
    }
}