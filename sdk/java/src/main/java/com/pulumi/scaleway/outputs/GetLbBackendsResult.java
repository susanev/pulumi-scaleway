// *** WARNING: this file was generated by pulumi-java-gen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package com.pulumi.scaleway.outputs;

import com.pulumi.core.annotations.CustomType;
import com.pulumi.scaleway.outputs.GetLbBackendsBackend;
import java.lang.String;
import java.util.List;
import java.util.Objects;
import java.util.Optional;
import javax.annotation.Nullable;

@CustomType
public final class GetLbBackendsResult {
    /**
     * @return List of found backends
     * 
     */
    private List<GetLbBackendsBackend> backends;
    /**
     * @return The provider-assigned unique ID for this managed resource.
     * 
     */
    private String id;
    private String lbId;
    private @Nullable String name;
    private String organizationId;
    private String projectId;
    private String zone;

    private GetLbBackendsResult() {}
    /**
     * @return List of found backends
     * 
     */
    public List<GetLbBackendsBackend> backends() {
        return this.backends;
    }
    /**
     * @return The provider-assigned unique ID for this managed resource.
     * 
     */
    public String id() {
        return this.id;
    }
    public String lbId() {
        return this.lbId;
    }
    public Optional<String> name() {
        return Optional.ofNullable(this.name);
    }
    public String organizationId() {
        return this.organizationId;
    }
    public String projectId() {
        return this.projectId;
    }
    public String zone() {
        return this.zone;
    }

    public static Builder builder() {
        return new Builder();
    }

    public static Builder builder(GetLbBackendsResult defaults) {
        return new Builder(defaults);
    }
    @CustomType.Builder
    public static final class Builder {
        private List<GetLbBackendsBackend> backends;
        private String id;
        private String lbId;
        private @Nullable String name;
        private String organizationId;
        private String projectId;
        private String zone;
        public Builder() {}
        public Builder(GetLbBackendsResult defaults) {
    	      Objects.requireNonNull(defaults);
    	      this.backends = defaults.backends;
    	      this.id = defaults.id;
    	      this.lbId = defaults.lbId;
    	      this.name = defaults.name;
    	      this.organizationId = defaults.organizationId;
    	      this.projectId = defaults.projectId;
    	      this.zone = defaults.zone;
        }

        @CustomType.Setter
        public Builder backends(List<GetLbBackendsBackend> backends) {
            this.backends = Objects.requireNonNull(backends);
            return this;
        }
        public Builder backends(GetLbBackendsBackend... backends) {
            return backends(List.of(backends));
        }
        @CustomType.Setter
        public Builder id(String id) {
            this.id = Objects.requireNonNull(id);
            return this;
        }
        @CustomType.Setter
        public Builder lbId(String lbId) {
            this.lbId = Objects.requireNonNull(lbId);
            return this;
        }
        @CustomType.Setter
        public Builder name(@Nullable String name) {
            this.name = name;
            return this;
        }
        @CustomType.Setter
        public Builder organizationId(String organizationId) {
            this.organizationId = Objects.requireNonNull(organizationId);
            return this;
        }
        @CustomType.Setter
        public Builder projectId(String projectId) {
            this.projectId = Objects.requireNonNull(projectId);
            return this;
        }
        @CustomType.Setter
        public Builder zone(String zone) {
            this.zone = Objects.requireNonNull(zone);
            return this;
        }
        public GetLbBackendsResult build() {
            final var o = new GetLbBackendsResult();
            o.backends = backends;
            o.id = id;
            o.lbId = lbId;
            o.name = name;
            o.organizationId = organizationId;
            o.projectId = projectId;
            o.zone = zone;
            return o;
        }
    }
}
