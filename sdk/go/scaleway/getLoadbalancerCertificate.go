// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package scaleway

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func LookupLoadbalancerCertificate(ctx *pulumi.Context, args *LookupLoadbalancerCertificateArgs, opts ...pulumi.InvokeOption) (*LookupLoadbalancerCertificateResult, error) {
	opts = pkgInvokeDefaultOpts(opts)
	var rv LookupLoadbalancerCertificateResult
	err := ctx.Invoke("scaleway:index/getLoadbalancerCertificate:getLoadbalancerCertificate", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getLoadbalancerCertificate.
type LookupLoadbalancerCertificateArgs struct {
	CertificateId *string `pulumi:"certificateId"`
	LbId          *string `pulumi:"lbId"`
	Name          *string `pulumi:"name"`
}

// A collection of values returned by getLoadbalancerCertificate.
type LookupLoadbalancerCertificateResult struct {
	CertificateId      *string                                       `pulumi:"certificateId"`
	CommonName         string                                        `pulumi:"commonName"`
	CustomCertificates []GetLoadbalancerCertificateCustomCertificate `pulumi:"customCertificates"`
	Fingerprint        string                                        `pulumi:"fingerprint"`
	// The provider-assigned unique ID for this managed resource.
	Id                      string                                  `pulumi:"id"`
	LbId                    *string                                 `pulumi:"lbId"`
	Letsencrypts            []GetLoadbalancerCertificateLetsencrypt `pulumi:"letsencrypts"`
	Name                    *string                                 `pulumi:"name"`
	NotValidAfter           string                                  `pulumi:"notValidAfter"`
	NotValidBefore          string                                  `pulumi:"notValidBefore"`
	Status                  string                                  `pulumi:"status"`
	SubjectAlternativeNames []string                                `pulumi:"subjectAlternativeNames"`
}

func LookupLoadbalancerCertificateOutput(ctx *pulumi.Context, args LookupLoadbalancerCertificateOutputArgs, opts ...pulumi.InvokeOption) LookupLoadbalancerCertificateResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupLoadbalancerCertificateResult, error) {
			args := v.(LookupLoadbalancerCertificateArgs)
			r, err := LookupLoadbalancerCertificate(ctx, &args, opts...)
			var s LookupLoadbalancerCertificateResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupLoadbalancerCertificateResultOutput)
}

// A collection of arguments for invoking getLoadbalancerCertificate.
type LookupLoadbalancerCertificateOutputArgs struct {
	CertificateId pulumi.StringPtrInput `pulumi:"certificateId"`
	LbId          pulumi.StringPtrInput `pulumi:"lbId"`
	Name          pulumi.StringPtrInput `pulumi:"name"`
}

func (LookupLoadbalancerCertificateOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupLoadbalancerCertificateArgs)(nil)).Elem()
}

// A collection of values returned by getLoadbalancerCertificate.
type LookupLoadbalancerCertificateResultOutput struct{ *pulumi.OutputState }

func (LookupLoadbalancerCertificateResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupLoadbalancerCertificateResult)(nil)).Elem()
}

func (o LookupLoadbalancerCertificateResultOutput) ToLookupLoadbalancerCertificateResultOutput() LookupLoadbalancerCertificateResultOutput {
	return o
}

func (o LookupLoadbalancerCertificateResultOutput) ToLookupLoadbalancerCertificateResultOutputWithContext(ctx context.Context) LookupLoadbalancerCertificateResultOutput {
	return o
}

func (o LookupLoadbalancerCertificateResultOutput) CertificateId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupLoadbalancerCertificateResult) *string { return v.CertificateId }).(pulumi.StringPtrOutput)
}

func (o LookupLoadbalancerCertificateResultOutput) CommonName() pulumi.StringOutput {
	return o.ApplyT(func(v LookupLoadbalancerCertificateResult) string { return v.CommonName }).(pulumi.StringOutput)
}

func (o LookupLoadbalancerCertificateResultOutput) CustomCertificates() GetLoadbalancerCertificateCustomCertificateArrayOutput {
	return o.ApplyT(func(v LookupLoadbalancerCertificateResult) []GetLoadbalancerCertificateCustomCertificate {
		return v.CustomCertificates
	}).(GetLoadbalancerCertificateCustomCertificateArrayOutput)
}

func (o LookupLoadbalancerCertificateResultOutput) Fingerprint() pulumi.StringOutput {
	return o.ApplyT(func(v LookupLoadbalancerCertificateResult) string { return v.Fingerprint }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupLoadbalancerCertificateResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupLoadbalancerCertificateResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupLoadbalancerCertificateResultOutput) LbId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupLoadbalancerCertificateResult) *string { return v.LbId }).(pulumi.StringPtrOutput)
}

func (o LookupLoadbalancerCertificateResultOutput) Letsencrypts() GetLoadbalancerCertificateLetsencryptArrayOutput {
	return o.ApplyT(func(v LookupLoadbalancerCertificateResult) []GetLoadbalancerCertificateLetsencrypt {
		return v.Letsencrypts
	}).(GetLoadbalancerCertificateLetsencryptArrayOutput)
}

func (o LookupLoadbalancerCertificateResultOutput) Name() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupLoadbalancerCertificateResult) *string { return v.Name }).(pulumi.StringPtrOutput)
}

func (o LookupLoadbalancerCertificateResultOutput) NotValidAfter() pulumi.StringOutput {
	return o.ApplyT(func(v LookupLoadbalancerCertificateResult) string { return v.NotValidAfter }).(pulumi.StringOutput)
}

func (o LookupLoadbalancerCertificateResultOutput) NotValidBefore() pulumi.StringOutput {
	return o.ApplyT(func(v LookupLoadbalancerCertificateResult) string { return v.NotValidBefore }).(pulumi.StringOutput)
}

func (o LookupLoadbalancerCertificateResultOutput) Status() pulumi.StringOutput {
	return o.ApplyT(func(v LookupLoadbalancerCertificateResult) string { return v.Status }).(pulumi.StringOutput)
}

func (o LookupLoadbalancerCertificateResultOutput) SubjectAlternativeNames() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupLoadbalancerCertificateResult) []string { return v.SubjectAlternativeNames }).(pulumi.StringArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupLoadbalancerCertificateResultOutput{})
}