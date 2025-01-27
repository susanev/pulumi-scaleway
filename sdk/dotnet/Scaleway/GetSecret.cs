// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Lbrlabs.PulumiPackage.Scaleway
{
    public static class GetSecret
    {
        /// <summary>
        /// Gets information about Scaleway Secrets.
        /// For more information, see [the documentation](https://developers.scaleway.com/en/products/secret_manager/api/v1alpha1/).
        /// 
        /// ## Examples
        /// 
        /// ### Basic
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Scaleway = Lbrlabs.PulumiPackage.Scaleway;
        /// using Scaleway = Pulumi.Scaleway;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var main = new Scaleway.Secret("main", new()
        ///     {
        ///         Description = "barr",
        ///     });
        /// 
        ///     var mySecret = Scaleway.GetSecret.Invoke(new()
        ///     {
        ///         SecretId = "11111111-1111-1111-1111-111111111111",
        ///     });
        /// 
        ///     var byName = Scaleway.GetSecret.Invoke(new()
        ///     {
        ///         Name = "your_secret_name",
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Task<GetSecretResult> InvokeAsync(GetSecretArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetSecretResult>("scaleway:index/getSecret:getSecret", args ?? new GetSecretArgs(), options.WithDefaults());

        /// <summary>
        /// Gets information about Scaleway Secrets.
        /// For more information, see [the documentation](https://developers.scaleway.com/en/products/secret_manager/api/v1alpha1/).
        /// 
        /// ## Examples
        /// 
        /// ### Basic
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Scaleway = Lbrlabs.PulumiPackage.Scaleway;
        /// using Scaleway = Pulumi.Scaleway;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var main = new Scaleway.Secret("main", new()
        ///     {
        ///         Description = "barr",
        ///     });
        /// 
        ///     var mySecret = Scaleway.GetSecret.Invoke(new()
        ///     {
        ///         SecretId = "11111111-1111-1111-1111-111111111111",
        ///     });
        /// 
        ///     var byName = Scaleway.GetSecret.Invoke(new()
        ///     {
        ///         Name = "your_secret_name",
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Output<GetSecretResult> Invoke(GetSecretInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetSecretResult>("scaleway:index/getSecret:getSecret", args ?? new GetSecretInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetSecretArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// The secret name.
        /// Only one of `name` and `secret_id` should be specified.
        /// </summary>
        [Input("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The organization ID the Project is associated with.
        /// If no default organization_id is set, one must be set explicitly in this datasource
        /// </summary>
        [Input("organizationId")]
        public string? OrganizationId { get; set; }

        /// <summary>
        /// `project_id`) The ID of the
        /// project the secret is associated with.
        /// </summary>
        [Input("projectId")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// `region`) The region in which the secret exists.
        /// </summary>
        [Input("region")]
        public string? Region { get; set; }

        /// <summary>
        /// The secret id.
        /// Only one of `name` and `secret_id` should be specified.
        /// </summary>
        [Input("secretId")]
        public string? SecretId { get; set; }

        public GetSecretArgs()
        {
        }
        public static new GetSecretArgs Empty => new GetSecretArgs();
    }

    public sealed class GetSecretInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// The secret name.
        /// Only one of `name` and `secret_id` should be specified.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The organization ID the Project is associated with.
        /// If no default organization_id is set, one must be set explicitly in this datasource
        /// </summary>
        [Input("organizationId")]
        public Input<string>? OrganizationId { get; set; }

        /// <summary>
        /// `project_id`) The ID of the
        /// project the secret is associated with.
        /// </summary>
        [Input("projectId")]
        public Input<string>? ProjectId { get; set; }

        /// <summary>
        /// `region`) The region in which the secret exists.
        /// </summary>
        [Input("region")]
        public Input<string>? Region { get; set; }

        /// <summary>
        /// The secret id.
        /// Only one of `name` and `secret_id` should be specified.
        /// </summary>
        [Input("secretId")]
        public Input<string>? SecretId { get; set; }

        public GetSecretInvokeArgs()
        {
        }
        public static new GetSecretInvokeArgs Empty => new GetSecretInvokeArgs();
    }


    [OutputType]
    public sealed class GetSecretResult
    {
        public readonly string CreatedAt;
        public readonly string Description;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string? Name;
        public readonly string OrganizationId;
        public readonly string? ProjectId;
        public readonly string? Region;
        public readonly string? SecretId;
        public readonly string Status;
        public readonly ImmutableArray<string> Tags;
        public readonly string UpdatedAt;
        public readonly int VersionCount;

        [OutputConstructor]
        private GetSecretResult(
            string createdAt,

            string description,

            string id,

            string? name,

            string organizationId,

            string? projectId,

            string? region,

            string? secretId,

            string status,

            ImmutableArray<string> tags,

            string updatedAt,

            int versionCount)
        {
            CreatedAt = createdAt;
            Description = description;
            Id = id;
            Name = name;
            OrganizationId = organizationId;
            ProjectId = projectId;
            Region = region;
            SecretId = secretId;
            Status = status;
            Tags = tags;
            UpdatedAt = updatedAt;
            VersionCount = versionCount;
        }
    }
}
