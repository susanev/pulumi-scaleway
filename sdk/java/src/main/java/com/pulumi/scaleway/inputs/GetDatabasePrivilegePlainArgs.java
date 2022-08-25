// *** WARNING: this file was generated by pulumi-java-gen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package com.pulumi.scaleway.inputs;

import com.pulumi.core.annotations.Import;
import java.lang.String;
import java.util.Objects;


public final class GetDatabasePrivilegePlainArgs extends com.pulumi.resources.InvokeArgs {

    public static final GetDatabasePrivilegePlainArgs Empty = new GetDatabasePrivilegePlainArgs();

    /**
     * The database name.
     * 
     */
    @Import(name="databaseName", required=true)
    private String databaseName;

    /**
     * @return The database name.
     * 
     */
    public String databaseName() {
        return this.databaseName;
    }

    /**
     * The RDB instance ID.
     * 
     */
    @Import(name="instanceId", required=true)
    private String instanceId;

    /**
     * @return The RDB instance ID.
     * 
     */
    public String instanceId() {
        return this.instanceId;
    }

    /**
     * The user name.
     * 
     */
    @Import(name="userName", required=true)
    private String userName;

    /**
     * @return The user name.
     * 
     */
    public String userName() {
        return this.userName;
    }

    private GetDatabasePrivilegePlainArgs() {}

    private GetDatabasePrivilegePlainArgs(GetDatabasePrivilegePlainArgs $) {
        this.databaseName = $.databaseName;
        this.instanceId = $.instanceId;
        this.userName = $.userName;
    }

    public static Builder builder() {
        return new Builder();
    }
    public static Builder builder(GetDatabasePrivilegePlainArgs defaults) {
        return new Builder(defaults);
    }

    public static final class Builder {
        private GetDatabasePrivilegePlainArgs $;

        public Builder() {
            $ = new GetDatabasePrivilegePlainArgs();
        }

        public Builder(GetDatabasePrivilegePlainArgs defaults) {
            $ = new GetDatabasePrivilegePlainArgs(Objects.requireNonNull(defaults));
        }

        /**
         * @param databaseName The database name.
         * 
         * @return builder
         * 
         */
        public Builder databaseName(String databaseName) {
            $.databaseName = databaseName;
            return this;
        }

        /**
         * @param instanceId The RDB instance ID.
         * 
         * @return builder
         * 
         */
        public Builder instanceId(String instanceId) {
            $.instanceId = instanceId;
            return this;
        }

        /**
         * @param userName The user name.
         * 
         * @return builder
         * 
         */
        public Builder userName(String userName) {
            $.userName = userName;
            return this;
        }

        public GetDatabasePrivilegePlainArgs build() {
            $.databaseName = Objects.requireNonNull($.databaseName, "expected parameter 'databaseName' to be non-null");
            $.instanceId = Objects.requireNonNull($.instanceId, "expected parameter 'instanceId' to be non-null");
            $.userName = Objects.requireNonNull($.userName, "expected parameter 'userName' to be non-null");
            return $;
        }
    }

}