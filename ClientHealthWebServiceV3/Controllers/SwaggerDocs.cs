using ClientHealthWebserviceV3.BL.Auth;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace ClientHealthWebServiceV3.Controllers
{
    public class SwaggerDocs : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            var attributes = context.MethodInfo.GetCustomAttributes(true);
            foreach (var attribute in attributes)
            {
                if (attribute is ApiKeyAuthorizationAttribute)
                {
                    if (operation.Parameters == null)
                        operation.Parameters = new List<OpenApiParameter>();

                    operation.Parameters.Add(new OpenApiParameter
                    {
                        Name = "ApiKey",
                        In = ParameterLocation.Header,
                        Required = true
                    });
                }
            }
        }
    }
}
