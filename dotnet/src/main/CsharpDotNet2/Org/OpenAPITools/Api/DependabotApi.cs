using System;
using System.Collections.Generic;
using RestSharp;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDependabotApi
    {
        /// <summary>
        /// Add selected repository to an organization secret Adds a repository to an organization secret when the &#x60;visibility&#x60; for repository access is set to &#x60;selected&#x60;. The visibility is set when you [Create or update an organization secret](https://docs.github.com/rest/reference/dependabot#create-or-update-an-organization-secret). You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;dependabot_secrets&#x60; organization permission to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="secretName">The name of the secret.</param>
        /// <param name="repositoryId"></param>
        /// <returns></returns>
        void DependabotAddSelectedRepoToOrgSecret (string org, string secretName, int? repositoryId);
        /// <summary>
        /// Create or update an organization secret Creates or updates an organization secret with an encrypted value. Encrypt your secret using [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages). You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;dependabot_secrets&#x60; organization permission to use this endpoint.  #### Example encrypting a secret using Node.js  Encrypt your secret using the [tweetsodium](https://github.com/github/tweetsodium) library.  &#x60;&#x60;&#x60; const sodium &#x3D; require(&#39;tweetsodium&#39;);  const key &#x3D; \&quot;base64-encoded-public-key\&quot;; const value &#x3D; \&quot;plain-text-secret\&quot;;  // Convert the message and key to Uint8Array&#39;s (Buffer implements that interface) const messageBytes &#x3D; Buffer.from(value); const keyBytes &#x3D; Buffer.from(key, &#39;base64&#39;);  // Encrypt using LibSodium. const encryptedBytes &#x3D; sodium.seal(messageBytes, keyBytes);  // Base64 the encrypted secret const encrypted &#x3D; Buffer.from(encryptedBytes).toString(&#39;base64&#39;);  console.log(encrypted); &#x60;&#x60;&#x60;   #### Example encrypting a secret using Python  Encrypt your secret using [pynacl](https://pynacl.readthedocs.io/en/latest/public/#nacl-public-sealedbox) with Python 3.  &#x60;&#x60;&#x60; from base64 import b64encode from nacl import encoding, public  def encrypt(public_key: str, secret_value: str) -&gt; str:   \&quot;\&quot;\&quot;Encrypt a Unicode string using the public key.\&quot;\&quot;\&quot;   public_key &#x3D; public.PublicKey(public_key.encode(\&quot;utf-8\&quot;), encoding.Base64Encoder())   sealed_box &#x3D; public.SealedBox(public_key)   encrypted &#x3D; sealed_box.encrypt(secret_value.encode(\&quot;utf-8\&quot;))   return b64encode(encrypted).decode(\&quot;utf-8\&quot;) &#x60;&#x60;&#x60;  #### Example encrypting a secret using C#  Encrypt your secret using the [Sodium.Core](https://www.nuget.org/packages/Sodium.Core/) package.  &#x60;&#x60;&#x60; var secretValue &#x3D; System.Text.Encoding.UTF8.GetBytes(\&quot;mySecret\&quot;); var publicKey &#x3D; Convert.FromBase64String(\&quot;2Sg8iYjAxxmI2LvUXpJjkYrMxURPc8r+dB7TJyvvcCU&#x3D;\&quot;);  var sealedPublicKeyBox &#x3D; Sodium.SealedPublicKeyBox.Create(secretValue, publicKey);  Console.WriteLine(Convert.ToBase64String(sealedPublicKeyBox)); &#x60;&#x60;&#x60;  #### Example encrypting a secret using Ruby  Encrypt your secret using the [rbnacl](https://github.com/RubyCrypto/rbnacl) gem.  &#x60;&#x60;&#x60;ruby require \&quot;rbnacl\&quot; require \&quot;base64\&quot;  key &#x3D; Base64.decode64(\&quot;+ZYvJDZMHUfBkJdyq5Zm9SKqeuBQ4sj+6sfjlH4CgG0&#x3D;\&quot;) public_key &#x3D; RbNaCl::PublicKey.new(key)  box &#x3D; RbNaCl::Boxes::Sealed.from_public_key(public_key) encrypted_secret &#x3D; box.encrypt(\&quot;my_secret\&quot;)  # Print the base64 encoded secret puts Base64.strict_encode64(encrypted_secret) &#x60;&#x60;&#x60;
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="secretName">The name of the secret.</param>
        /// <param name="dependabotCreateOrUpdateOrgSecretRequest"></param>
        /// <returns>Object</returns>
        Object DependabotCreateOrUpdateOrgSecret (string org, string secretName, DependabotCreateOrUpdateOrgSecretRequest dependabotCreateOrUpdateOrgSecretRequest);
        /// <summary>
        /// Create or update a repository secret Creates or updates a repository secret with an encrypted value. Encrypt your secret using [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages). You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;dependabot_secrets&#x60; repository permission to use this endpoint.  #### Example encrypting a secret using Node.js  Encrypt your secret using the [tweetsodium](https://github.com/github/tweetsodium) library.  &#x60;&#x60;&#x60; const sodium &#x3D; require(&#39;tweetsodium&#39;);  const key &#x3D; \&quot;base64-encoded-public-key\&quot;; const value &#x3D; \&quot;plain-text-secret\&quot;;  // Convert the message and key to Uint8Array&#39;s (Buffer implements that interface) const messageBytes &#x3D; Buffer.from(value); const keyBytes &#x3D; Buffer.from(key, &#39;base64&#39;);  // Encrypt using LibSodium. const encryptedBytes &#x3D; sodium.seal(messageBytes, keyBytes);  // Base64 the encrypted secret const encrypted &#x3D; Buffer.from(encryptedBytes).toString(&#39;base64&#39;);  console.log(encrypted); &#x60;&#x60;&#x60;   #### Example encrypting a secret using Python  Encrypt your secret using [pynacl](https://pynacl.readthedocs.io/en/latest/public/#nacl-public-sealedbox) with Python 3.  &#x60;&#x60;&#x60; from base64 import b64encode from nacl import encoding, public  def encrypt(public_key: str, secret_value: str) -&gt; str:   \&quot;\&quot;\&quot;Encrypt a Unicode string using the public key.\&quot;\&quot;\&quot;   public_key &#x3D; public.PublicKey(public_key.encode(\&quot;utf-8\&quot;), encoding.Base64Encoder())   sealed_box &#x3D; public.SealedBox(public_key)   encrypted &#x3D; sealed_box.encrypt(secret_value.encode(\&quot;utf-8\&quot;))   return b64encode(encrypted).decode(\&quot;utf-8\&quot;) &#x60;&#x60;&#x60;  #### Example encrypting a secret using C#  Encrypt your secret using the [Sodium.Core](https://www.nuget.org/packages/Sodium.Core/) package.  &#x60;&#x60;&#x60; var secretValue &#x3D; System.Text.Encoding.UTF8.GetBytes(\&quot;mySecret\&quot;); var publicKey &#x3D; Convert.FromBase64String(\&quot;2Sg8iYjAxxmI2LvUXpJjkYrMxURPc8r+dB7TJyvvcCU&#x3D;\&quot;);  var sealedPublicKeyBox &#x3D; Sodium.SealedPublicKeyBox.Create(secretValue, publicKey);  Console.WriteLine(Convert.ToBase64String(sealedPublicKeyBox)); &#x60;&#x60;&#x60;  #### Example encrypting a secret using Ruby  Encrypt your secret using the [rbnacl](https://github.com/RubyCrypto/rbnacl) gem.  &#x60;&#x60;&#x60;ruby require \&quot;rbnacl\&quot; require \&quot;base64\&quot;  key &#x3D; Base64.decode64(\&quot;+ZYvJDZMHUfBkJdyq5Zm9SKqeuBQ4sj+6sfjlH4CgG0&#x3D;\&quot;) public_key &#x3D; RbNaCl::PublicKey.new(key)  box &#x3D; RbNaCl::Boxes::Sealed.from_public_key(public_key) encrypted_secret &#x3D; box.encrypt(\&quot;my_secret\&quot;)  # Print the base64 encoded secret puts Base64.strict_encode64(encrypted_secret) &#x60;&#x60;&#x60;
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="secretName">The name of the secret.</param>
        /// <param name="dependabotCreateOrUpdateRepoSecretRequest"></param>
        /// <returns>Object</returns>
        Object DependabotCreateOrUpdateRepoSecret (string owner, string repo, string secretName, DependabotCreateOrUpdateRepoSecretRequest dependabotCreateOrUpdateRepoSecretRequest);
        /// <summary>
        /// Delete an organization secret Deletes a secret in an organization using the secret name. You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;dependabot_secrets&#x60; organization permission to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="secretName">The name of the secret.</param>
        /// <returns></returns>
        void DependabotDeleteOrgSecret (string org, string secretName);
        /// <summary>
        /// Delete a repository secret Deletes a secret in a repository using the secret name. You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;dependabot_secrets&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="secretName">The name of the secret.</param>
        /// <returns></returns>
        void DependabotDeleteRepoSecret (string owner, string repo, string secretName);
        /// <summary>
        /// Get an organization public key Gets your public key, which you need to encrypt secrets. You need to encrypt a secret before you can create or update secrets. You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;dependabot_secrets&#x60; organization permission to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <returns>DependabotPublicKey</returns>
        DependabotPublicKey DependabotGetOrgPublicKey (string org);
        /// <summary>
        /// Get an organization secret Gets a single organization secret without revealing its encrypted value. You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;dependabot_secrets&#x60; organization permission to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="secretName">The name of the secret.</param>
        /// <returns>DependabotSecretForAnOrganization</returns>
        DependabotSecretForAnOrganization DependabotGetOrgSecret (string org, string secretName);
        /// <summary>
        /// Get a repository public key Gets your public key, which you need to encrypt secrets. You need to encrypt a secret before you can create or update secrets. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the &#x60;repo&#x60; scope. GitHub Apps must have the &#x60;dependabot_secrets&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>DependabotPublicKey</returns>
        DependabotPublicKey DependabotGetRepoPublicKey (string owner, string repo);
        /// <summary>
        /// Get a repository secret Gets a single repository secret without revealing its encrypted value. You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;dependabot_secrets&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="secretName">The name of the secret.</param>
        /// <returns>DependabotSecret</returns>
        DependabotSecret DependabotGetRepoSecret (string owner, string repo, string secretName);
        /// <summary>
        /// List organization secrets Lists all secrets available in an organization without revealing their encrypted values. You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;dependabot_secrets&#x60; organization permission to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>DependabotListOrgSecrets200Response</returns>
        DependabotListOrgSecrets200Response DependabotListOrgSecrets (string org, int? perPage, int? page);
        /// <summary>
        /// List repository secrets Lists all secrets available in a repository without revealing their encrypted values. You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;dependabot_secrets&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>DependabotListRepoSecrets200Response</returns>
        DependabotListRepoSecrets200Response DependabotListRepoSecrets (string owner, string repo, int? perPage, int? page);
        /// <summary>
        /// List selected repositories for an organization secret Lists all repositories that have been selected when the &#x60;visibility&#x60; for repository access to a secret is set to &#x60;selected&#x60;. You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;dependabot_secrets&#x60; organization permission to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="secretName">The name of the secret.</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <returns>ActionsListSelectedReposForOrgSecret200Response</returns>
        ActionsListSelectedReposForOrgSecret200Response DependabotListSelectedReposForOrgSecret (string org, string secretName, int? page, int? perPage);
        /// <summary>
        /// Remove selected repository from an organization secret Removes a repository from an organization secret when the &#x60;visibility&#x60; for repository access is set to &#x60;selected&#x60;. The visibility is set when you [Create or update an organization secret](https://docs.github.com/rest/reference/dependabot#create-or-update-an-organization-secret). You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;dependabot_secrets&#x60; organization permission to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="secretName">The name of the secret.</param>
        /// <param name="repositoryId"></param>
        /// <returns></returns>
        void DependabotRemoveSelectedRepoFromOrgSecret (string org, string secretName, int? repositoryId);
        /// <summary>
        /// Set selected repositories for an organization secret Replaces all repositories for an organization secret when the &#x60;visibility&#x60; for repository access is set to &#x60;selected&#x60;. The visibility is set when you [Create or update an organization secret](https://docs.github.com/rest/reference/dependabot#create-or-update-an-organization-secret). You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;dependabot_secrets&#x60; organization permission to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="secretName">The name of the secret.</param>
        /// <param name="dependabotSetSelectedReposForOrgSecretRequest"></param>
        /// <returns></returns>
        void DependabotSetSelectedReposForOrgSecret (string org, string secretName, DependabotSetSelectedReposForOrgSecretRequest dependabotSetSelectedReposForOrgSecretRequest);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DependabotApi : IDependabotApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DependabotApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public DependabotApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DependabotApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DependabotApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }

        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}

        /// <summary>
        /// Add selected repository to an organization secret Adds a repository to an organization secret when the &#x60;visibility&#x60; for repository access is set to &#x60;selected&#x60;. The visibility is set when you [Create or update an organization secret](https://docs.github.com/rest/reference/dependabot#create-or-update-an-organization-secret). You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;dependabot_secrets&#x60; organization permission to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="secretName">The name of the secret.</param>
        /// <param name="repositoryId"></param>
        /// <returns></returns>
        public void DependabotAddSelectedRepoToOrgSecret (string org, string secretName, int? repositoryId)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling DependabotAddSelectedRepoToOrgSecret");
            
            // verify the required parameter 'secretName' is set
            if (secretName == null) throw new ApiException(400, "Missing required parameter 'secretName' when calling DependabotAddSelectedRepoToOrgSecret");
            
            // verify the required parameter 'repositoryId' is set
            if (repositoryId == null) throw new ApiException(400, "Missing required parameter 'repositoryId' when calling DependabotAddSelectedRepoToOrgSecret");
            

            var path = "/orgs/{org}/dependabot/secrets/{secret_name}/repositories/{repository_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "secret_name" + "}", ApiClient.ParameterToString(secretName));
path = path.Replace("{" + "repository_id" + "}", ApiClient.ParameterToString(repositoryId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DependabotAddSelectedRepoToOrgSecret: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DependabotAddSelectedRepoToOrgSecret: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Create or update an organization secret Creates or updates an organization secret with an encrypted value. Encrypt your secret using [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages). You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;dependabot_secrets&#x60; organization permission to use this endpoint.  #### Example encrypting a secret using Node.js  Encrypt your secret using the [tweetsodium](https://github.com/github/tweetsodium) library.  &#x60;&#x60;&#x60; const sodium &#x3D; require(&#39;tweetsodium&#39;);  const key &#x3D; \&quot;base64-encoded-public-key\&quot;; const value &#x3D; \&quot;plain-text-secret\&quot;;  // Convert the message and key to Uint8Array&#39;s (Buffer implements that interface) const messageBytes &#x3D; Buffer.from(value); const keyBytes &#x3D; Buffer.from(key, &#39;base64&#39;);  // Encrypt using LibSodium. const encryptedBytes &#x3D; sodium.seal(messageBytes, keyBytes);  // Base64 the encrypted secret const encrypted &#x3D; Buffer.from(encryptedBytes).toString(&#39;base64&#39;);  console.log(encrypted); &#x60;&#x60;&#x60;   #### Example encrypting a secret using Python  Encrypt your secret using [pynacl](https://pynacl.readthedocs.io/en/latest/public/#nacl-public-sealedbox) with Python 3.  &#x60;&#x60;&#x60; from base64 import b64encode from nacl import encoding, public  def encrypt(public_key: str, secret_value: str) -&gt; str:   \&quot;\&quot;\&quot;Encrypt a Unicode string using the public key.\&quot;\&quot;\&quot;   public_key &#x3D; public.PublicKey(public_key.encode(\&quot;utf-8\&quot;), encoding.Base64Encoder())   sealed_box &#x3D; public.SealedBox(public_key)   encrypted &#x3D; sealed_box.encrypt(secret_value.encode(\&quot;utf-8\&quot;))   return b64encode(encrypted).decode(\&quot;utf-8\&quot;) &#x60;&#x60;&#x60;  #### Example encrypting a secret using C#  Encrypt your secret using the [Sodium.Core](https://www.nuget.org/packages/Sodium.Core/) package.  &#x60;&#x60;&#x60; var secretValue &#x3D; System.Text.Encoding.UTF8.GetBytes(\&quot;mySecret\&quot;); var publicKey &#x3D; Convert.FromBase64String(\&quot;2Sg8iYjAxxmI2LvUXpJjkYrMxURPc8r+dB7TJyvvcCU&#x3D;\&quot;);  var sealedPublicKeyBox &#x3D; Sodium.SealedPublicKeyBox.Create(secretValue, publicKey);  Console.WriteLine(Convert.ToBase64String(sealedPublicKeyBox)); &#x60;&#x60;&#x60;  #### Example encrypting a secret using Ruby  Encrypt your secret using the [rbnacl](https://github.com/RubyCrypto/rbnacl) gem.  &#x60;&#x60;&#x60;ruby require \&quot;rbnacl\&quot; require \&quot;base64\&quot;  key &#x3D; Base64.decode64(\&quot;+ZYvJDZMHUfBkJdyq5Zm9SKqeuBQ4sj+6sfjlH4CgG0&#x3D;\&quot;) public_key &#x3D; RbNaCl::PublicKey.new(key)  box &#x3D; RbNaCl::Boxes::Sealed.from_public_key(public_key) encrypted_secret &#x3D; box.encrypt(\&quot;my_secret\&quot;)  # Print the base64 encoded secret puts Base64.strict_encode64(encrypted_secret) &#x60;&#x60;&#x60;
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="secretName">The name of the secret.</param>
        /// <param name="dependabotCreateOrUpdateOrgSecretRequest"></param>
        /// <returns>Object</returns>
        public Object DependabotCreateOrUpdateOrgSecret (string org, string secretName, DependabotCreateOrUpdateOrgSecretRequest dependabotCreateOrUpdateOrgSecretRequest)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling DependabotCreateOrUpdateOrgSecret");
            
            // verify the required parameter 'secretName' is set
            if (secretName == null) throw new ApiException(400, "Missing required parameter 'secretName' when calling DependabotCreateOrUpdateOrgSecret");
            
            // verify the required parameter 'dependabotCreateOrUpdateOrgSecretRequest' is set
            if (dependabotCreateOrUpdateOrgSecretRequest == null) throw new ApiException(400, "Missing required parameter 'dependabotCreateOrUpdateOrgSecretRequest' when calling DependabotCreateOrUpdateOrgSecret");
            

            var path = "/orgs/{org}/dependabot/secrets/{secret_name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "secret_name" + "}", ApiClient.ParameterToString(secretName));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(dependabotCreateOrUpdateOrgSecretRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DependabotCreateOrUpdateOrgSecret: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DependabotCreateOrUpdateOrgSecret: " + response.ErrorMessage, response.ErrorMessage);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }

        /// <summary>
        /// Create or update a repository secret Creates or updates a repository secret with an encrypted value. Encrypt your secret using [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages). You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;dependabot_secrets&#x60; repository permission to use this endpoint.  #### Example encrypting a secret using Node.js  Encrypt your secret using the [tweetsodium](https://github.com/github/tweetsodium) library.  &#x60;&#x60;&#x60; const sodium &#x3D; require(&#39;tweetsodium&#39;);  const key &#x3D; \&quot;base64-encoded-public-key\&quot;; const value &#x3D; \&quot;plain-text-secret\&quot;;  // Convert the message and key to Uint8Array&#39;s (Buffer implements that interface) const messageBytes &#x3D; Buffer.from(value); const keyBytes &#x3D; Buffer.from(key, &#39;base64&#39;);  // Encrypt using LibSodium. const encryptedBytes &#x3D; sodium.seal(messageBytes, keyBytes);  // Base64 the encrypted secret const encrypted &#x3D; Buffer.from(encryptedBytes).toString(&#39;base64&#39;);  console.log(encrypted); &#x60;&#x60;&#x60;   #### Example encrypting a secret using Python  Encrypt your secret using [pynacl](https://pynacl.readthedocs.io/en/latest/public/#nacl-public-sealedbox) with Python 3.  &#x60;&#x60;&#x60; from base64 import b64encode from nacl import encoding, public  def encrypt(public_key: str, secret_value: str) -&gt; str:   \&quot;\&quot;\&quot;Encrypt a Unicode string using the public key.\&quot;\&quot;\&quot;   public_key &#x3D; public.PublicKey(public_key.encode(\&quot;utf-8\&quot;), encoding.Base64Encoder())   sealed_box &#x3D; public.SealedBox(public_key)   encrypted &#x3D; sealed_box.encrypt(secret_value.encode(\&quot;utf-8\&quot;))   return b64encode(encrypted).decode(\&quot;utf-8\&quot;) &#x60;&#x60;&#x60;  #### Example encrypting a secret using C#  Encrypt your secret using the [Sodium.Core](https://www.nuget.org/packages/Sodium.Core/) package.  &#x60;&#x60;&#x60; var secretValue &#x3D; System.Text.Encoding.UTF8.GetBytes(\&quot;mySecret\&quot;); var publicKey &#x3D; Convert.FromBase64String(\&quot;2Sg8iYjAxxmI2LvUXpJjkYrMxURPc8r+dB7TJyvvcCU&#x3D;\&quot;);  var sealedPublicKeyBox &#x3D; Sodium.SealedPublicKeyBox.Create(secretValue, publicKey);  Console.WriteLine(Convert.ToBase64String(sealedPublicKeyBox)); &#x60;&#x60;&#x60;  #### Example encrypting a secret using Ruby  Encrypt your secret using the [rbnacl](https://github.com/RubyCrypto/rbnacl) gem.  &#x60;&#x60;&#x60;ruby require \&quot;rbnacl\&quot; require \&quot;base64\&quot;  key &#x3D; Base64.decode64(\&quot;+ZYvJDZMHUfBkJdyq5Zm9SKqeuBQ4sj+6sfjlH4CgG0&#x3D;\&quot;) public_key &#x3D; RbNaCl::PublicKey.new(key)  box &#x3D; RbNaCl::Boxes::Sealed.from_public_key(public_key) encrypted_secret &#x3D; box.encrypt(\&quot;my_secret\&quot;)  # Print the base64 encoded secret puts Base64.strict_encode64(encrypted_secret) &#x60;&#x60;&#x60;
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="secretName">The name of the secret.</param>
        /// <param name="dependabotCreateOrUpdateRepoSecretRequest"></param>
        /// <returns>Object</returns>
        public Object DependabotCreateOrUpdateRepoSecret (string owner, string repo, string secretName, DependabotCreateOrUpdateRepoSecretRequest dependabotCreateOrUpdateRepoSecretRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling DependabotCreateOrUpdateRepoSecret");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling DependabotCreateOrUpdateRepoSecret");
            
            // verify the required parameter 'secretName' is set
            if (secretName == null) throw new ApiException(400, "Missing required parameter 'secretName' when calling DependabotCreateOrUpdateRepoSecret");
            
            // verify the required parameter 'dependabotCreateOrUpdateRepoSecretRequest' is set
            if (dependabotCreateOrUpdateRepoSecretRequest == null) throw new ApiException(400, "Missing required parameter 'dependabotCreateOrUpdateRepoSecretRequest' when calling DependabotCreateOrUpdateRepoSecret");
            

            var path = "/repos/{owner}/{repo}/dependabot/secrets/{secret_name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "secret_name" + "}", ApiClient.ParameterToString(secretName));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(dependabotCreateOrUpdateRepoSecretRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DependabotCreateOrUpdateRepoSecret: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DependabotCreateOrUpdateRepoSecret: " + response.ErrorMessage, response.ErrorMessage);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }

        /// <summary>
        /// Delete an organization secret Deletes a secret in an organization using the secret name. You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;dependabot_secrets&#x60; organization permission to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="secretName">The name of the secret.</param>
        /// <returns></returns>
        public void DependabotDeleteOrgSecret (string org, string secretName)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling DependabotDeleteOrgSecret");
            
            // verify the required parameter 'secretName' is set
            if (secretName == null) throw new ApiException(400, "Missing required parameter 'secretName' when calling DependabotDeleteOrgSecret");
            

            var path = "/orgs/{org}/dependabot/secrets/{secret_name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "secret_name" + "}", ApiClient.ParameterToString(secretName));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DependabotDeleteOrgSecret: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DependabotDeleteOrgSecret: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Delete a repository secret Deletes a secret in a repository using the secret name. You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;dependabot_secrets&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="secretName">The name of the secret.</param>
        /// <returns></returns>
        public void DependabotDeleteRepoSecret (string owner, string repo, string secretName)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling DependabotDeleteRepoSecret");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling DependabotDeleteRepoSecret");
            
            // verify the required parameter 'secretName' is set
            if (secretName == null) throw new ApiException(400, "Missing required parameter 'secretName' when calling DependabotDeleteRepoSecret");
            

            var path = "/repos/{owner}/{repo}/dependabot/secrets/{secret_name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "secret_name" + "}", ApiClient.ParameterToString(secretName));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DependabotDeleteRepoSecret: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DependabotDeleteRepoSecret: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Get an organization public key Gets your public key, which you need to encrypt secrets. You need to encrypt a secret before you can create or update secrets. You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;dependabot_secrets&#x60; organization permission to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <returns>DependabotPublicKey</returns>
        public DependabotPublicKey DependabotGetOrgPublicKey (string org)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling DependabotGetOrgPublicKey");
            

            var path = "/orgs/{org}/dependabot/secrets/public-key";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DependabotGetOrgPublicKey: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DependabotGetOrgPublicKey: " + response.ErrorMessage, response.ErrorMessage);

            return (DependabotPublicKey) ApiClient.Deserialize(response.Content, typeof(DependabotPublicKey), response.Headers);
        }

        /// <summary>
        /// Get an organization secret Gets a single organization secret without revealing its encrypted value. You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;dependabot_secrets&#x60; organization permission to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="secretName">The name of the secret.</param>
        /// <returns>DependabotSecretForAnOrganization</returns>
        public DependabotSecretForAnOrganization DependabotGetOrgSecret (string org, string secretName)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling DependabotGetOrgSecret");
            
            // verify the required parameter 'secretName' is set
            if (secretName == null) throw new ApiException(400, "Missing required parameter 'secretName' when calling DependabotGetOrgSecret");
            

            var path = "/orgs/{org}/dependabot/secrets/{secret_name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "secret_name" + "}", ApiClient.ParameterToString(secretName));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DependabotGetOrgSecret: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DependabotGetOrgSecret: " + response.ErrorMessage, response.ErrorMessage);

            return (DependabotSecretForAnOrganization) ApiClient.Deserialize(response.Content, typeof(DependabotSecretForAnOrganization), response.Headers);
        }

        /// <summary>
        /// Get a repository public key Gets your public key, which you need to encrypt secrets. You need to encrypt a secret before you can create or update secrets. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the &#x60;repo&#x60; scope. GitHub Apps must have the &#x60;dependabot_secrets&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>DependabotPublicKey</returns>
        public DependabotPublicKey DependabotGetRepoPublicKey (string owner, string repo)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling DependabotGetRepoPublicKey");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling DependabotGetRepoPublicKey");
            

            var path = "/repos/{owner}/{repo}/dependabot/secrets/public-key";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DependabotGetRepoPublicKey: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DependabotGetRepoPublicKey: " + response.ErrorMessage, response.ErrorMessage);

            return (DependabotPublicKey) ApiClient.Deserialize(response.Content, typeof(DependabotPublicKey), response.Headers);
        }

        /// <summary>
        /// Get a repository secret Gets a single repository secret without revealing its encrypted value. You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;dependabot_secrets&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="secretName">The name of the secret.</param>
        /// <returns>DependabotSecret</returns>
        public DependabotSecret DependabotGetRepoSecret (string owner, string repo, string secretName)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling DependabotGetRepoSecret");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling DependabotGetRepoSecret");
            
            // verify the required parameter 'secretName' is set
            if (secretName == null) throw new ApiException(400, "Missing required parameter 'secretName' when calling DependabotGetRepoSecret");
            

            var path = "/repos/{owner}/{repo}/dependabot/secrets/{secret_name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "secret_name" + "}", ApiClient.ParameterToString(secretName));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DependabotGetRepoSecret: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DependabotGetRepoSecret: " + response.ErrorMessage, response.ErrorMessage);

            return (DependabotSecret) ApiClient.Deserialize(response.Content, typeof(DependabotSecret), response.Headers);
        }

        /// <summary>
        /// List organization secrets Lists all secrets available in an organization without revealing their encrypted values. You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;dependabot_secrets&#x60; organization permission to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>DependabotListOrgSecrets200Response</returns>
        public DependabotListOrgSecrets200Response DependabotListOrgSecrets (string org, int? perPage, int? page)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling DependabotListOrgSecrets");
            

            var path = "/orgs/{org}/dependabot/secrets";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DependabotListOrgSecrets: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DependabotListOrgSecrets: " + response.ErrorMessage, response.ErrorMessage);

            return (DependabotListOrgSecrets200Response) ApiClient.Deserialize(response.Content, typeof(DependabotListOrgSecrets200Response), response.Headers);
        }

        /// <summary>
        /// List repository secrets Lists all secrets available in a repository without revealing their encrypted values. You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;dependabot_secrets&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>DependabotListRepoSecrets200Response</returns>
        public DependabotListRepoSecrets200Response DependabotListRepoSecrets (string owner, string repo, int? perPage, int? page)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling DependabotListRepoSecrets");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling DependabotListRepoSecrets");
            

            var path = "/repos/{owner}/{repo}/dependabot/secrets";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DependabotListRepoSecrets: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DependabotListRepoSecrets: " + response.ErrorMessage, response.ErrorMessage);

            return (DependabotListRepoSecrets200Response) ApiClient.Deserialize(response.Content, typeof(DependabotListRepoSecrets200Response), response.Headers);
        }

        /// <summary>
        /// List selected repositories for an organization secret Lists all repositories that have been selected when the &#x60;visibility&#x60; for repository access to a secret is set to &#x60;selected&#x60;. You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;dependabot_secrets&#x60; organization permission to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="secretName">The name of the secret.</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <returns>ActionsListSelectedReposForOrgSecret200Response</returns>
        public ActionsListSelectedReposForOrgSecret200Response DependabotListSelectedReposForOrgSecret (string org, string secretName, int? page, int? perPage)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling DependabotListSelectedReposForOrgSecret");
            
            // verify the required parameter 'secretName' is set
            if (secretName == null) throw new ApiException(400, "Missing required parameter 'secretName' when calling DependabotListSelectedReposForOrgSecret");
            

            var path = "/orgs/{org}/dependabot/secrets/{secret_name}/repositories";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "secret_name" + "}", ApiClient.ParameterToString(secretName));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DependabotListSelectedReposForOrgSecret: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DependabotListSelectedReposForOrgSecret: " + response.ErrorMessage, response.ErrorMessage);

            return (ActionsListSelectedReposForOrgSecret200Response) ApiClient.Deserialize(response.Content, typeof(ActionsListSelectedReposForOrgSecret200Response), response.Headers);
        }

        /// <summary>
        /// Remove selected repository from an organization secret Removes a repository from an organization secret when the &#x60;visibility&#x60; for repository access is set to &#x60;selected&#x60;. The visibility is set when you [Create or update an organization secret](https://docs.github.com/rest/reference/dependabot#create-or-update-an-organization-secret). You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;dependabot_secrets&#x60; organization permission to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="secretName">The name of the secret.</param>
        /// <param name="repositoryId"></param>
        /// <returns></returns>
        public void DependabotRemoveSelectedRepoFromOrgSecret (string org, string secretName, int? repositoryId)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling DependabotRemoveSelectedRepoFromOrgSecret");
            
            // verify the required parameter 'secretName' is set
            if (secretName == null) throw new ApiException(400, "Missing required parameter 'secretName' when calling DependabotRemoveSelectedRepoFromOrgSecret");
            
            // verify the required parameter 'repositoryId' is set
            if (repositoryId == null) throw new ApiException(400, "Missing required parameter 'repositoryId' when calling DependabotRemoveSelectedRepoFromOrgSecret");
            

            var path = "/orgs/{org}/dependabot/secrets/{secret_name}/repositories/{repository_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "secret_name" + "}", ApiClient.ParameterToString(secretName));
path = path.Replace("{" + "repository_id" + "}", ApiClient.ParameterToString(repositoryId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DependabotRemoveSelectedRepoFromOrgSecret: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DependabotRemoveSelectedRepoFromOrgSecret: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Set selected repositories for an organization secret Replaces all repositories for an organization secret when the &#x60;visibility&#x60; for repository access is set to &#x60;selected&#x60;. The visibility is set when you [Create or update an organization secret](https://docs.github.com/rest/reference/dependabot#create-or-update-an-organization-secret). You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;dependabot_secrets&#x60; organization permission to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="secretName">The name of the secret.</param>
        /// <param name="dependabotSetSelectedReposForOrgSecretRequest"></param>
        /// <returns></returns>
        public void DependabotSetSelectedReposForOrgSecret (string org, string secretName, DependabotSetSelectedReposForOrgSecretRequest dependabotSetSelectedReposForOrgSecretRequest)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling DependabotSetSelectedReposForOrgSecret");
            
            // verify the required parameter 'secretName' is set
            if (secretName == null) throw new ApiException(400, "Missing required parameter 'secretName' when calling DependabotSetSelectedReposForOrgSecret");
            
            // verify the required parameter 'dependabotSetSelectedReposForOrgSecretRequest' is set
            if (dependabotSetSelectedReposForOrgSecretRequest == null) throw new ApiException(400, "Missing required parameter 'dependabotSetSelectedReposForOrgSecretRequest' when calling DependabotSetSelectedReposForOrgSecret");
            

            var path = "/orgs/{org}/dependabot/secrets/{secret_name}/repositories";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "secret_name" + "}", ApiClient.ParameterToString(secretName));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(dependabotSetSelectedReposForOrgSecretRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DependabotSetSelectedReposForOrgSecret: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DependabotSetSelectedReposForOrgSecret: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

    }
}
