#pragma checksum "C:\Users\slore\source\repos\SendSmsBlazor\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1bdae5dc4a323dd6117f1c6728fbcf961151fba"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SendSmsBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\slore\source\repos\SendSmsBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\slore\source\repos\SendSmsBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\slore\source\repos\SendSmsBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\slore\source\repos\SendSmsBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\slore\source\repos\SendSmsBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\slore\source\repos\SendSmsBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\slore\source\repos\SendSmsBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\slore\source\repos\SendSmsBlazor\_Imports.razor"
using SendSmsBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\slore\source\repos\SendSmsBlazor\_Imports.razor"
using SendSmsBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\slore\source\repos\SendSmsBlazor\Pages\Index.razor"
using SendSmsBlazor.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "C:\Users\slore\source\repos\SendSmsBlazor\Pages\Index.razor"
      
    private string To;
    private string From;
    private string Text;
    private string MessageId;
    private void SendSms()
    {
        var response = SmsService.SendSms(To, From, Text);
        MessageId = response.Messages[0].MessageId;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SmsService SmsService { get; set; }
    }
}
#pragma warning restore 1591