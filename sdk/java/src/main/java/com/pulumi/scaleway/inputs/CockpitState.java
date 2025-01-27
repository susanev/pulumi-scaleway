// *** WARNING: this file was generated by pulumi-java-gen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package com.pulumi.scaleway.inputs;

import com.pulumi.core.Output;
import com.pulumi.core.annotations.Import;
import com.pulumi.scaleway.inputs.CockpitEndpointArgs;
import java.lang.String;
import java.util.List;
import java.util.Objects;
import java.util.Optional;
import javax.annotation.Nullable;


public final class CockpitState extends com.pulumi.resources.ResourceArgs {

    public static final CockpitState Empty = new CockpitState();

    /**
     * Endpoints
     * 
     */
    @Import(name="endpoints")
    private @Nullable Output<List<CockpitEndpointArgs>> endpoints;

    /**
     * @return Endpoints
     * 
     */
    public Optional<Output<List<CockpitEndpointArgs>>> endpoints() {
        return Optional.ofNullable(this.endpoints);
    }

    /**
     * `project_id`) The ID of the project the cockpit is associated with.
     * 
     */
    @Import(name="projectId")
    private @Nullable Output<String> projectId;

    /**
     * @return `project_id`) The ID of the project the cockpit is associated with.
     * 
     */
    public Optional<Output<String>> projectId() {
        return Optional.ofNullable(this.projectId);
    }

    private CockpitState() {}

    private CockpitState(CockpitState $) {
        this.endpoints = $.endpoints;
        this.projectId = $.projectId;
    }

    public static Builder builder() {
        return new Builder();
    }
    public static Builder builder(CockpitState defaults) {
        return new Builder(defaults);
    }

    public static final class Builder {
        private CockpitState $;

        public Builder() {
            $ = new CockpitState();
        }

        public Builder(CockpitState defaults) {
            $ = new CockpitState(Objects.requireNonNull(defaults));
        }

        /**
         * @param endpoints Endpoints
         * 
         * @return builder
         * 
         */
        public Builder endpoints(@Nullable Output<List<CockpitEndpointArgs>> endpoints) {
            $.endpoints = endpoints;
            return this;
        }

        /**
         * @param endpoints Endpoints
         * 
         * @return builder
         * 
         */
        public Builder endpoints(List<CockpitEndpointArgs> endpoints) {
            return endpoints(Output.of(endpoints));
        }

        /**
         * @param endpoints Endpoints
         * 
         * @return builder
         * 
         */
        public Builder endpoints(CockpitEndpointArgs... endpoints) {
            return endpoints(List.of(endpoints));
        }

        /**
         * @param projectId `project_id`) The ID of the project the cockpit is associated with.
         * 
         * @return builder
         * 
         */
        public Builder projectId(@Nullable Output<String> projectId) {
            $.projectId = projectId;
            return this;
        }

        /**
         * @param projectId `project_id`) The ID of the project the cockpit is associated with.
         * 
         * @return builder
         * 
         */
        public Builder projectId(String projectId) {
            return projectId(Output.of(projectId));
        }

        public CockpitState build() {
            return $;
        }
    }

}
