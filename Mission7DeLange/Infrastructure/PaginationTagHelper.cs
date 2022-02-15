using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Mission7DeLange.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission7DeLange.Infrastructure
{
    [HtmlTargetElement("div", Attributes ="page-blah")]
    public class PaginationTagHelper : TagHelper
    {
        //dynamically create page links for us
        private IUrlHelperFactory uhf;

        public PaginationTagHelper(IUrlHelperFactory temp)
        {
            uhf = temp;
        }
        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext vc { get; set; }

        // items being passed to the class
        public PageInfo PageBlah { get; set; }
        public string PageAction { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            IUrlHelper uh = uhf.GetUrlHelper(vc);
            TagBuilder final = new TagBuilder("div");
            for (int i =1; i <= PageBlah.TotalPages; i++)
            {
                //create an a tag for each necessary page
                TagBuilder tb = new TagBuilder("a");
                // set action it will link to and parameters
                tb.Attributes["href"] = uh.Action(PageAction, new { pageNum = i });
                tb.AddCssClass("btn btn-primary ml-2");
                tb.InnerHtml.Append(i.ToString());
                final.InnerHtml.AppendHtml(tb);

            }
            output.Content.AppendHtml(final.InnerHtml);
        }

    }
}
