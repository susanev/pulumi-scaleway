// *** WARNING: this file was generated by pulumi-java-gen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package com.pulumi.scaleway.outputs;

import com.pulumi.core.annotations.CustomType;
import com.pulumi.scaleway.outputs.GetLbAclsAclActionRedirect;
import java.lang.String;
import java.util.List;
import java.util.Objects;

@CustomType
public final class GetLbAclsAclAction {
    /**
     * @return Redirect parameters when using an ACL with `redirect` action.
     * 
     */
    private List<GetLbAclsAclActionRedirect> redirects;
    /**
     * @return The redirect type.
     * 
     */
    private String type;

    private GetLbAclsAclAction() {}
    /**
     * @return Redirect parameters when using an ACL with `redirect` action.
     * 
     */
    public List<GetLbAclsAclActionRedirect> redirects() {
        return this.redirects;
    }
    /**
     * @return The redirect type.
     * 
     */
    public String type() {
        return this.type;
    }

    public static Builder builder() {
        return new Builder();
    }

    public static Builder builder(GetLbAclsAclAction defaults) {
        return new Builder(defaults);
    }
    @CustomType.Builder
    public static final class Builder {
        private List<GetLbAclsAclActionRedirect> redirects;
        private String type;
        public Builder() {}
        public Builder(GetLbAclsAclAction defaults) {
    	      Objects.requireNonNull(defaults);
    	      this.redirects = defaults.redirects;
    	      this.type = defaults.type;
        }

        @CustomType.Setter
        public Builder redirects(List<GetLbAclsAclActionRedirect> redirects) {
            this.redirects = Objects.requireNonNull(redirects);
            return this;
        }
        public Builder redirects(GetLbAclsAclActionRedirect... redirects) {
            return redirects(List.of(redirects));
        }
        @CustomType.Setter
        public Builder type(String type) {
            this.type = Objects.requireNonNull(type);
            return this;
        }
        public GetLbAclsAclAction build() {
            final var o = new GetLbAclsAclAction();
            o.redirects = redirects;
            o.type = type;
            return o;
        }
    }
}