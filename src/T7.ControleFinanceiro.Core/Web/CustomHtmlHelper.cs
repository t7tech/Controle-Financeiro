using Newtonsoft.Json;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace T7.ControleFinanceiro.Core.Web
{
    public static class CustomHtmlHelper
    {
        public static MvcHtmlString AngularJSModel(this HtmlHelper helper, object model, string property = "model")
        {
            var scriptTag = new TagBuilder("script");
            scriptTag.MergeAttribute("type", "text/javascript");

            /*
             * Define a variável que armazenará o modelo em formato Json
             */
            var jsonModel = new StringBuilder();
            jsonModel.AppendFormat("var {0} =", property);
            jsonModel.Append(SerializeHelper.ToJson(model));
            jsonModel.Append(";");

            /*
             * Atribui o conteúdo no Elemento Javascript no Formato Html
             */
            scriptTag.InnerHtml = jsonModel.ToString();

            /*
             * Renderiza o Elemento JavaScript
             */
            return MvcHtmlString.Create(scriptTag.ToString(TagRenderMode.Normal));
        }
    }
}