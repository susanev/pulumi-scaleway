// *** WARNING: this file was generated by pulumi-java-gen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package com.pulumi.scaleway.inputs;

import com.pulumi.core.Output;
import com.pulumi.core.annotations.Import;
import java.lang.String;
import java.util.Objects;
import java.util.Optional;
import javax.annotation.Nullable;


public final class GetVpcPublicPatRuleArgs extends com.pulumi.resources.InvokeArgs {

    public static final GetVpcPublicPatRuleArgs Empty = new GetVpcPublicPatRuleArgs();

    /**
     * The ID of the PAT rule to retrieve
     * 
     */
    @Import(name="patRuleId", required=true)
    private Output<String> patRuleId;

    /**
     * @return The ID of the PAT rule to retrieve
     * 
     */
    public Output<String> patRuleId() {
        return this.patRuleId;
    }

    /**
     * `zone`) The zone in which
     * the image exists.
     * 
     */
    @Import(name="zone")
    private @Nullable Output<String> zone;

    /**
     * @return `zone`) The zone in which
     * the image exists.
     * 
     */
    public Optional<Output<String>> zone() {
        return Optional.ofNullable(this.zone);
    }

    private GetVpcPublicPatRuleArgs() {}

    private GetVpcPublicPatRuleArgs(GetVpcPublicPatRuleArgs $) {
        this.patRuleId = $.patRuleId;
        this.zone = $.zone;
    }

    public static Builder builder() {
        return new Builder();
    }
    public static Builder builder(GetVpcPublicPatRuleArgs defaults) {
        return new Builder(defaults);
    }

    public static final class Builder {
        private GetVpcPublicPatRuleArgs $;

        public Builder() {
            $ = new GetVpcPublicPatRuleArgs();
        }

        public Builder(GetVpcPublicPatRuleArgs defaults) {
            $ = new GetVpcPublicPatRuleArgs(Objects.requireNonNull(defaults));
        }

        /**
         * @param patRuleId The ID of the PAT rule to retrieve
         * 
         * @return builder
         * 
         */
        public Builder patRuleId(Output<String> patRuleId) {
            $.patRuleId = patRuleId;
            return this;
        }

        /**
         * @param patRuleId The ID of the PAT rule to retrieve
         * 
         * @return builder
         * 
         */
        public Builder patRuleId(String patRuleId) {
            return patRuleId(Output.of(patRuleId));
        }

        /**
         * @param zone `zone`) The zone in which
         * the image exists.
         * 
         * @return builder
         * 
         */
        public Builder zone(@Nullable Output<String> zone) {
            $.zone = zone;
            return this;
        }

        /**
         * @param zone `zone`) The zone in which
         * the image exists.
         * 
         * @return builder
         * 
         */
        public Builder zone(String zone) {
            return zone(Output.of(zone));
        }

        public GetVpcPublicPatRuleArgs build() {
            $.patRuleId = Objects.requireNonNull($.patRuleId, "expected parameter 'patRuleId' to be non-null");
            return $;
        }
    }

}