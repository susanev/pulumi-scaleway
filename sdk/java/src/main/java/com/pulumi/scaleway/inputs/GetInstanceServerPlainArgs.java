// *** WARNING: this file was generated by pulumi-java-gen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package com.pulumi.scaleway.inputs;

import com.pulumi.core.annotations.Import;
import java.lang.String;
import java.util.Objects;
import java.util.Optional;
import javax.annotation.Nullable;


public final class GetInstanceServerPlainArgs extends com.pulumi.resources.InvokeArgs {

    public static final GetInstanceServerPlainArgs Empty = new GetInstanceServerPlainArgs();

    /**
     * The server name. Only one of `name` and `server_id` should be specified.
     * 
     */
    @Import(name="name")
    private @Nullable String name;

    /**
     * @return The server name. Only one of `name` and `server_id` should be specified.
     * 
     */
    public Optional<String> name() {
        return Optional.ofNullable(this.name);
    }

    /**
     * The server id. Only one of `name` and `server_id` should be specified.
     * 
     */
    @Import(name="serverId")
    private @Nullable String serverId;

    /**
     * @return The server id. Only one of `name` and `server_id` should be specified.
     * 
     */
    public Optional<String> serverId() {
        return Optional.ofNullable(this.serverId);
    }

    /**
     * `zone`) The zone in which the server exists.
     * 
     */
    @Import(name="zone")
    private @Nullable String zone;

    /**
     * @return `zone`) The zone in which the server exists.
     * 
     */
    public Optional<String> zone() {
        return Optional.ofNullable(this.zone);
    }

    private GetInstanceServerPlainArgs() {}

    private GetInstanceServerPlainArgs(GetInstanceServerPlainArgs $) {
        this.name = $.name;
        this.serverId = $.serverId;
        this.zone = $.zone;
    }

    public static Builder builder() {
        return new Builder();
    }
    public static Builder builder(GetInstanceServerPlainArgs defaults) {
        return new Builder(defaults);
    }

    public static final class Builder {
        private GetInstanceServerPlainArgs $;

        public Builder() {
            $ = new GetInstanceServerPlainArgs();
        }

        public Builder(GetInstanceServerPlainArgs defaults) {
            $ = new GetInstanceServerPlainArgs(Objects.requireNonNull(defaults));
        }

        /**
         * @param name The server name. Only one of `name` and `server_id` should be specified.
         * 
         * @return builder
         * 
         */
        public Builder name(@Nullable String name) {
            $.name = name;
            return this;
        }

        /**
         * @param serverId The server id. Only one of `name` and `server_id` should be specified.
         * 
         * @return builder
         * 
         */
        public Builder serverId(@Nullable String serverId) {
            $.serverId = serverId;
            return this;
        }

        /**
         * @param zone `zone`) The zone in which the server exists.
         * 
         * @return builder
         * 
         */
        public Builder zone(@Nullable String zone) {
            $.zone = zone;
            return this;
        }

        public GetInstanceServerPlainArgs build() {
            return $;
        }
    }

}