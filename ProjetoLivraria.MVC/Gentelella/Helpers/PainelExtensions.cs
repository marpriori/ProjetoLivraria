using System;
using System.IO;
using System.Web.Mvc;

namespace ProjetoLivraria.MVC.Gentelella.Helpers
{
    public static class PainelExtensions
    {
        private class PainelHelper : IDisposable
        {
            private readonly TextWriter _writer;

            public PainelHelper(TextWriter writer)
            {
                _writer = writer;
            }

            public void Dispose()
            {
                _writer.Write("</div></div></div></div>");
            }
        }

        public const string HTMLBASE = @"<div class=''>
                                <div class='row'>
                                    <div class='col-md-12 col-sm-12 col-xs-12'>
                                        <div class='x_panel'>";

        private static IDisposable CriarPainelHelper(HtmlHelper htmlHelper, string htmlContent)
        {
            var writer = htmlHelper.ViewContext.Writer;

            writer.WriteLine(htmlContent);

            return new PainelHelper(writer);
        }

        public static IDisposable CreatePainel(this HtmlHelper htmlHelper, string title, string smallTitle)
        {

            var painelBase = HTMLBASE + @"<div class='x_title'>
                                                <h2>{0}<small>{1}</small></h2>
                                                <div class='clearfix'></div>
                                            </div>";

            return CriarPainelHelper(htmlHelper, string.Format(painelBase, title, smallTitle));
        }

        public static IDisposable CreatePainelWithoutTitle(this HtmlHelper htmlHelper)
        {
            return CriarPainelHelper(htmlHelper, HTMLBASE);
        }
    }
}