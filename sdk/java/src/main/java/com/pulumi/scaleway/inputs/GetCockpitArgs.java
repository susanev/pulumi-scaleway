// *** WARNING: this file was generated by pulumi-java-gen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package com.pulumi.scaleway.inputs;

import com.pulumi.core.Output;
import com.pulumi.core.annotations.Import;
import java.lang.String;
import java.util.Objects;
import java.util.Optional;
import javax.annotation.Nullable;


public final class GetCockpitArgs extends com.pulumi.resources.InvokeArgs {

    public static final GetCockpitArgs Empty = new GetCockpitArgs();

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

    private GetCockpitArgs() {}

    private GetCockpitArgs(GetCockpitArgs $) {
        this.projectId = $.projectId;
    }

    public static Builder builder() {
        return new Builder();
    }
    public static Builder builder(GetCockpitArgs defaults) {
        return new Builder(defaults);
    }

    public static final class Builder {
        private GetCockpitArgs $;

        public Builder() {
            $ = new GetCockpitArgs();
        }

        public Builder(GetCockpitArgs defaults) {
            $ = new GetCockpitArgs(Objects.requireNonNull(defaults));
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

        public GetCockpitArgs build() {
            return $;
        }
    }

}
