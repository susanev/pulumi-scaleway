// *** WARNING: this file was generated by pulumi-java-gen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package com.pulumi.scaleway;

import com.pulumi.core.Output;
import com.pulumi.core.annotations.Import;
import java.lang.String;
import java.util.Objects;
import java.util.Optional;
import javax.annotation.Nullable;


public final class ContainerDomainArgs extends com.pulumi.resources.ResourceArgs {

    public static final ContainerDomainArgs Empty = new ContainerDomainArgs();

    /**
     * The ID of the container.
     * 
     */
    @Import(name="containerId", required=true)
    private Output<String> containerId;

    /**
     * @return The ID of the container.
     * 
     */
    public Output<String> containerId() {
        return this.containerId;
    }

    /**
     * The hostname with a CNAME record.
     * 
     */
    @Import(name="hostname", required=true)
    private Output<String> hostname;

    /**
     * @return The hostname with a CNAME record.
     * 
     */
    public Output<String> hostname() {
        return this.hostname;
    }

    /**
     * `region`) The region in which the container exists
     * 
     */
    @Import(name="region")
    private @Nullable Output<String> region;

    /**
     * @return `region`) The region in which the container exists
     * 
     */
    public Optional<Output<String>> region() {
        return Optional.ofNullable(this.region);
    }

    private ContainerDomainArgs() {}

    private ContainerDomainArgs(ContainerDomainArgs $) {
        this.containerId = $.containerId;
        this.hostname = $.hostname;
        this.region = $.region;
    }

    public static Builder builder() {
        return new Builder();
    }
    public static Builder builder(ContainerDomainArgs defaults) {
        return new Builder(defaults);
    }

    public static final class Builder {
        private ContainerDomainArgs $;

        public Builder() {
            $ = new ContainerDomainArgs();
        }

        public Builder(ContainerDomainArgs defaults) {
            $ = new ContainerDomainArgs(Objects.requireNonNull(defaults));
        }

        /**
         * @param containerId The ID of the container.
         * 
         * @return builder
         * 
         */
        public Builder containerId(Output<String> containerId) {
            $.containerId = containerId;
            return this;
        }

        /**
         * @param containerId The ID of the container.
         * 
         * @return builder
         * 
         */
        public Builder containerId(String containerId) {
            return containerId(Output.of(containerId));
        }

        /**
         * @param hostname The hostname with a CNAME record.
         * 
         * @return builder
         * 
         */
        public Builder hostname(Output<String> hostname) {
            $.hostname = hostname;
            return this;
        }

        /**
         * @param hostname The hostname with a CNAME record.
         * 
         * @return builder
         * 
         */
        public Builder hostname(String hostname) {
            return hostname(Output.of(hostname));
        }

        /**
         * @param region `region`) The region in which the container exists
         * 
         * @return builder
         * 
         */
        public Builder region(@Nullable Output<String> region) {
            $.region = region;
            return this;
        }

        /**
         * @param region `region`) The region in which the container exists
         * 
         * @return builder
         * 
         */
        public Builder region(String region) {
            return region(Output.of(region));
        }

        public ContainerDomainArgs build() {
            $.containerId = Objects.requireNonNull($.containerId, "expected parameter 'containerId' to be non-null");
            $.hostname = Objects.requireNonNull($.hostname, "expected parameter 'hostname' to be non-null");
            return $;
        }
    }

}
