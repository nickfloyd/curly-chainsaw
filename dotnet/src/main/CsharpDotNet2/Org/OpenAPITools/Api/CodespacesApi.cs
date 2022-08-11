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
    public interface ICodespacesApi
    {
        /// <summary>
        /// Add a selected repository to a user secret Adds a repository to the selected repositories for a user&#39;s codespace secret. You must authenticate using an access token with the &#x60;codespace&#x60; or &#x60;codespace:secrets&#x60; scope to use this endpoint. User must have Codespaces access to use this endpoint. GitHub Apps must have write access to the &#x60;codespaces_user_secrets&#x60; user permission and write access to the &#x60;codespaces_secrets&#x60; repository permission on the referenced repository to use this endpoint.
        /// </summary>
        /// <param name="secretName">The name of the secret.</param>
        /// <param name="repositoryId"></param>
        /// <returns></returns>
        void CodespacesAddRepositoryForSecretForAuthenticatedUser (string secretName, int? repositoryId);
        /// <summary>
        /// List machine types for a codespace List the machine types a codespace can transition to use.  You must authenticate using an access token with the &#x60;codespace&#x60; scope to use this endpoint.  GitHub Apps must have read access to the &#x60;codespaces_metadata&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="codespaceName">The name of the codespace.</param>
        /// <returns>CodespacesRepoMachinesForAuthenticatedUser200Response</returns>
        CodespacesRepoMachinesForAuthenticatedUser200Response CodespacesCodespaceMachinesForAuthenticatedUser (string codespaceName);
        /// <summary>
        /// Create a codespace for the authenticated user Creates a new codespace, owned by the authenticated user.  This endpoint requires either a &#x60;repository_id&#x60; OR a &#x60;pull_request&#x60; but not both.  You must authenticate using an access token with the &#x60;codespace&#x60; scope to use this endpoint.  GitHub Apps must have write access to the &#x60;codespaces&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="codespacesCreateForAuthenticatedUserRequest"></param>
        /// <returns>Codespace</returns>
        Codespace CodespacesCreateForAuthenticatedUser (CodespacesCreateForAuthenticatedUserRequest codespacesCreateForAuthenticatedUserRequest);
        /// <summary>
        /// Create or update a repository secret Creates or updates a repository secret with an encrypted value. Encrypt your secret using [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages). You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;codespaces_secrets&#x60; repository permission to use this endpoint.  #### Example of encrypting a secret using Node.js  Encrypt your secret using the [tweetsodium](https://github.com/github/tweetsodium) library.  &#x60;&#x60;&#x60; const sodium &#x3D; require(&#39;tweetsodium&#39;);  const key &#x3D; \&quot;base64-encoded-public-key\&quot;; const value &#x3D; \&quot;plain-text-secret\&quot;;  // Convert the message and key to Uint8Array&#39;s (Buffer implements that interface) const messageBytes &#x3D; Buffer.from(value); const keyBytes &#x3D; Buffer.from(key, &#39;base64&#39;);  // Encrypt using LibSodium. const encryptedBytes &#x3D; sodium.seal(messageBytes, keyBytes);  // Base64 the encrypted secret const encrypted &#x3D; Buffer.from(encryptedBytes).toString(&#39;base64&#39;);  console.log(encrypted); &#x60;&#x60;&#x60;   #### Example of encrypting a secret using Python  Encrypt your secret using [pynacl](https://pynacl.readthedocs.io/en/latest/public/#nacl-public-sealedbox) with Python 3.  &#x60;&#x60;&#x60; from base64 import b64encode from nacl import encoding, public  def encrypt(public_key: str, secret_value: str) -&gt; str:   \&quot;\&quot;\&quot;Encrypt a Unicode string using the public key.\&quot;\&quot;\&quot;   public_key &#x3D; public.PublicKey(public_key.encode(\&quot;utf-8\&quot;), encoding.Base64Encoder())   sealed_box &#x3D; public.SealedBox(public_key)   encrypted &#x3D; sealed_box.encrypt(secret_value.encode(\&quot;utf-8\&quot;))   return b64encode(encrypted).decode(\&quot;utf-8\&quot;) &#x60;&#x60;&#x60;  #### Example of encrypting a secret using C#  Encrypt your secret using the [Sodium.Core](https://www.nuget.org/packages/Sodium.Core/) package.  &#x60;&#x60;&#x60; var secretValue &#x3D; System.Text.Encoding.UTF8.GetBytes(\&quot;mySecret\&quot;); var publicKey &#x3D; Convert.FromBase64String(\&quot;2Sg8iYjAxxmI2LvUXpJjkYrMxURPc8r+dB7TJyvvcCU&#x3D;\&quot;);  var sealedPublicKeyBox &#x3D; Sodium.SealedPublicKeyBox.Create(secretValue, publicKey);  Console.WriteLine(Convert.ToBase64String(sealedPublicKeyBox)); &#x60;&#x60;&#x60;  #### Example of encrypting a secret using Ruby  Encrypt your secret using the [rbnacl](https://github.com/RubyCrypto/rbnacl) gem.  &#x60;&#x60;&#x60;ruby require \&quot;rbnacl\&quot; require \&quot;base64\&quot;  key &#x3D; Base64.decode64(\&quot;+ZYvJDZMHUfBkJdyq5Zm9SKqeuBQ4sj+6sfjlH4CgG0&#x3D;\&quot;) public_key &#x3D; RbNaCl::PublicKey.new(key)  box &#x3D; RbNaCl::Boxes::Sealed.from_public_key(public_key) encrypted_secret &#x3D; box.encrypt(\&quot;my_secret\&quot;)  # Print the base64 encoded secret puts Base64.strict_encode64(encrypted_secret) &#x60;&#x60;&#x60;
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="secretName">The name of the secret.</param>
        /// <param name="codespacesCreateOrUpdateRepoSecretRequest"></param>
        /// <returns>Object</returns>
        Object CodespacesCreateOrUpdateRepoSecret (string owner, string repo, string secretName, CodespacesCreateOrUpdateRepoSecretRequest codespacesCreateOrUpdateRepoSecretRequest);
        /// <summary>
        /// Create or update a secret for the authenticated user Creates or updates a secret for a user&#39;s codespace with an encrypted value. Encrypt your secret using [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages).  You must authenticate using an access token with the &#x60;codespace&#x60; or &#x60;codespace:secrets&#x60; scope to use this endpoint. User must also have Codespaces access to use this endpoint.  GitHub Apps must have read access to the &#x60;codespaces_user_secrets&#x60; user permission and &#x60;codespaces_secrets&#x60; repository permission on all referenced repositories to use this endpoint.  #### Example encrypting a secret using Node.js  Encrypt your secret using the [tweetsodium](https://github.com/github/tweetsodium) library.  &#x60;&#x60;&#x60; const sodium &#x3D; require(&#39;tweetsodium&#39;);  const key &#x3D; \&quot;base64-encoded-public-key\&quot;; const value &#x3D; \&quot;plain-text-secret\&quot;;  // Convert the message and key to Uint8Array&#39;s (Buffer implements that interface) const messageBytes &#x3D; Buffer.from(value); const keyBytes &#x3D; Buffer.from(key, &#39;base64&#39;);  // Encrypt using LibSodium. const encryptedBytes &#x3D; sodium.seal(messageBytes, keyBytes);  // Base64 the encrypted secret const encrypted &#x3D; Buffer.from(encryptedBytes).toString(&#39;base64&#39;);  console.log(encrypted); &#x60;&#x60;&#x60;   #### Example encrypting a secret using Python  Encrypt your secret using [pynacl](https://pynacl.readthedocs.io/en/latest/public/#nacl-public-sealedbox) with Python 3.  &#x60;&#x60;&#x60; from base64 import b64encode from nacl import encoding, public  def encrypt(public_key: str, secret_value: str) -&gt; str:   \&quot;\&quot;\&quot;Encrypt a Unicode string using the public key.\&quot;\&quot;\&quot;   public_key &#x3D; public.PublicKey(public_key.encode(\&quot;utf-8\&quot;), encoding.Base64Encoder())   sealed_box &#x3D; public.SealedBox(public_key)   encrypted &#x3D; sealed_box.encrypt(secret_value.encode(\&quot;utf-8\&quot;))   return b64encode(encrypted).decode(\&quot;utf-8\&quot;) &#x60;&#x60;&#x60;  #### Example encrypting a secret using C#  Encrypt your secret using the [Sodium.Core](https://www.nuget.org/packages/Sodium.Core/) package.  &#x60;&#x60;&#x60; var secretValue &#x3D; System.Text.Encoding.UTF8.GetBytes(\&quot;mySecret\&quot;); var publicKey &#x3D; Convert.FromBase64String(\&quot;2Sg8iYjAxxmI2LvUXpJjkYrMxURPc8r+dB7TJyvvcCU&#x3D;\&quot;);  var sealedPublicKeyBox &#x3D; Sodium.SealedPublicKeyBox.Create(secretValue, publicKey);  Console.WriteLine(Convert.ToBase64String(sealedPublicKeyBox)); &#x60;&#x60;&#x60;  #### Example encrypting a secret using Ruby  Encrypt your secret using the [rbnacl](https://github.com/RubyCrypto/rbnacl) gem.  &#x60;&#x60;&#x60;ruby require \&quot;rbnacl\&quot; require \&quot;base64\&quot;  key &#x3D; Base64.decode64(\&quot;+ZYvJDZMHUfBkJdyq5Zm9SKqeuBQ4sj+6sfjlH4CgG0&#x3D;\&quot;) public_key &#x3D; RbNaCl::PublicKey.new(key)  box &#x3D; RbNaCl::Boxes::Sealed.from_public_key(public_key) encrypted_secret &#x3D; box.encrypt(\&quot;my_secret\&quot;)  # Print the base64 encoded secret puts Base64.strict_encode64(encrypted_secret) &#x60;&#x60;&#x60;
        /// </summary>
        /// <param name="secretName">The name of the secret.</param>
        /// <param name="codespacesCreateOrUpdateSecretForAuthenticatedUserRequest"></param>
        /// <returns>Object</returns>
        Object CodespacesCreateOrUpdateSecretForAuthenticatedUser (string secretName, CodespacesCreateOrUpdateSecretForAuthenticatedUserRequest codespacesCreateOrUpdateSecretForAuthenticatedUserRequest);
        /// <summary>
        /// Create a codespace from a pull request Creates a codespace owned by the authenticated user for the specified pull request.  You must authenticate using an access token with the &#x60;codespace&#x60; scope to use this endpoint.  GitHub Apps must have write access to the &#x60;codespaces&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="pullNumber">The number that identifies the pull request.</param>
        /// <param name="codespacesCreateWithPrForAuthenticatedUserRequest"></param>
        /// <returns>Codespace</returns>
        Codespace CodespacesCreateWithPrForAuthenticatedUser (string owner, string repo, int? pullNumber, CodespacesCreateWithPrForAuthenticatedUserRequest codespacesCreateWithPrForAuthenticatedUserRequest);
        /// <summary>
        /// Create a codespace in a repository Creates a codespace owned by the authenticated user in the specified repository.  You must authenticate using an access token with the &#x60;codespace&#x60; scope to use this endpoint.  GitHub Apps must have write access to the &#x60;codespaces&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="codespacesCreateWithRepoForAuthenticatedUserRequest"></param>
        /// <returns>Codespace</returns>
        Codespace CodespacesCreateWithRepoForAuthenticatedUser (string owner, string repo, CodespacesCreateWithRepoForAuthenticatedUserRequest codespacesCreateWithRepoForAuthenticatedUserRequest);
        /// <summary>
        /// Delete a codespace for the authenticated user Deletes a user&#39;s codespace.  You must authenticate using an access token with the &#x60;codespace&#x60; scope to use this endpoint.  GitHub Apps must have write access to the &#x60;codespaces&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="codespaceName">The name of the codespace.</param>
        /// <returns>Object</returns>
        Object CodespacesDeleteForAuthenticatedUser (string codespaceName);
        /// <summary>
        /// Delete a codespace from the organization Deletes a user&#39;s codespace.  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <param name="codespaceName">The name of the codespace.</param>
        /// <returns>Object</returns>
        Object CodespacesDeleteFromOrganization (string org, string username, string codespaceName);
        /// <summary>
        /// Delete a repository secret Deletes a secret in a repository using the secret name. You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;codespaces_secrets&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="secretName">The name of the secret.</param>
        /// <returns></returns>
        void CodespacesDeleteRepoSecret (string owner, string repo, string secretName);
        /// <summary>
        /// Delete a secret for the authenticated user Deletes a secret from a user&#39;s codespaces using the secret name. Deleting the secret will remove access from all codespaces that were allowed to access the secret.  You must authenticate using an access token with the &#x60;codespace&#x60; or &#x60;codespace:secrets&#x60; scope to use this endpoint. User must have Codespaces access to use this endpoint.  GitHub Apps must have write access to the &#x60;codespaces_user_secrets&#x60; user permission to use this endpoint.
        /// </summary>
        /// <param name="secretName">The name of the secret.</param>
        /// <returns></returns>
        void CodespacesDeleteSecretForAuthenticatedUser (string secretName);
        /// <summary>
        /// Export a codespace for the authenticated user Triggers an export of the specified codespace and returns a URL and ID where the status of the export can be monitored.  You must authenticate using a personal access token with the &#x60;codespace&#x60; scope to use this endpoint.  GitHub Apps must have write access to the &#x60;codespaces_lifecycle_admin&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="codespaceName">The name of the codespace.</param>
        /// <returns>FetchesInformationAboutAnExportOfACodespace</returns>
        FetchesInformationAboutAnExportOfACodespace CodespacesExportForAuthenticatedUser (string codespaceName);
        /// <summary>
        /// Get details about a codespace export Gets information about an export of a codespace.  You must authenticate using a personal access token with the &#x60;codespace&#x60; scope to use this endpoint.  GitHub Apps must have read access to the &#x60;codespaces_lifecycle_admin&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="codespaceName">The name of the codespace.</param>
        /// <param name="exportId">The ID of the export operation, or &#x60;latest&#x60;. Currently only &#x60;latest&#x60; is currently supported.</param>
        /// <returns>FetchesInformationAboutAnExportOfACodespace</returns>
        FetchesInformationAboutAnExportOfACodespace CodespacesGetExportDetailsForAuthenticatedUser (string codespaceName, string exportId);
        /// <summary>
        /// Get a codespace for the authenticated user Gets information about a user&#39;s codespace.  You must authenticate using an access token with the &#x60;codespace&#x60; scope to use this endpoint.  GitHub Apps must have read access to the &#x60;codespaces&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="codespaceName">The name of the codespace.</param>
        /// <returns>Codespace</returns>
        Codespace CodespacesGetForAuthenticatedUser (string codespaceName);
        /// <summary>
        /// Get public key for the authenticated user Gets your public key, which you need to encrypt secrets. You need to encrypt a secret before you can create or update secrets.  You must authenticate using an access token with the &#x60;codespace&#x60; or &#x60;codespace:secrets&#x60; scope to use this endpoint. User must have Codespaces access to use this endpoint.  GitHub Apps must have read access to the &#x60;codespaces_user_secrets&#x60; user permission to use this endpoint.
        /// </summary>
        /// <returns>CodespacesUserPublicKey</returns>
        CodespacesUserPublicKey CodespacesGetPublicKeyForAuthenticatedUser ();
        /// <summary>
        /// Get a repository public key Gets your public key, which you need to encrypt secrets. You need to encrypt a secret before you can create or update secrets. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the &#x60;repo&#x60; scope. GitHub Apps must have the &#x60;codespaces_secrets&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>CodespacesPublicKey</returns>
        CodespacesPublicKey CodespacesGetRepoPublicKey (string owner, string repo);
        /// <summary>
        /// Get a repository secret Gets a single repository secret without revealing its encrypted value. You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;codespaces_secrets&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="secretName">The name of the secret.</param>
        /// <returns>CodespacesSecret</returns>
        CodespacesSecret CodespacesGetRepoSecret (string owner, string repo, string secretName);
        /// <summary>
        /// Get a secret for the authenticated user Gets a secret available to a user&#39;s codespaces without revealing its encrypted value.  You must authenticate using an access token with the &#x60;codespace&#x60; or &#x60;codespace:secrets&#x60; scope to use this endpoint. User must have Codespaces access to use this endpoint.  GitHub Apps must have read access to the &#x60;codespaces_user_secrets&#x60; user permission to use this endpoint.
        /// </summary>
        /// <param name="secretName">The name of the secret.</param>
        /// <returns>CodespacesSecret1</returns>
        CodespacesSecret1 CodespacesGetSecretForAuthenticatedUser (string secretName);
        /// <summary>
        /// List devcontainer configurations in a repository for the authenticated user Lists the devcontainer.json files associated with a specified repository and the authenticated user. These files specify launchpoint configurations for codespaces created within the repository.  You must authenticate using an access token with the &#x60;codespace&#x60; scope to use this endpoint.  GitHub Apps must have read access to the &#x60;codespaces_metadata&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>CodespacesListDevcontainersInRepositoryForAuthenticatedUser200Response</returns>
        CodespacesListDevcontainersInRepositoryForAuthenticatedUser200Response CodespacesListDevcontainersInRepositoryForAuthenticatedUser (string owner, string repo, int? perPage, int? page);
        /// <summary>
        /// List codespaces for the authenticated user Lists the authenticated user&#39;s codespaces.  You must authenticate using an access token with the &#x60;codespace&#x60; scope to use this endpoint.  GitHub Apps must have read access to the &#x60;codespaces&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <param name="repositoryId">ID of the Repository to filter on</param>
        /// <returns>CodespacesListInOrganization200Response</returns>
        CodespacesListInOrganization200Response CodespacesListForAuthenticatedUser (int? perPage, int? page, int? repositoryId);
        /// <summary>
        /// List codespaces for the organization Lists the codespaces associated to a specified organization.  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>CodespacesListInOrganization200Response</returns>
        CodespacesListInOrganization200Response CodespacesListInOrganization (string org, int? perPage, int? page);
        /// <summary>
        /// List codespaces in a repository for the authenticated user Lists the codespaces associated to a specified repository and the authenticated user.  You must authenticate using an access token with the &#x60;codespace&#x60; scope to use this endpoint.  GitHub Apps must have read access to the &#x60;codespaces&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>CodespacesListInOrganization200Response</returns>
        CodespacesListInOrganization200Response CodespacesListInRepositoryForAuthenticatedUser (string owner, string repo, int? perPage, int? page);
        /// <summary>
        /// List repository secrets Lists all secrets available in a repository without revealing their encrypted values. You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;codespaces_secrets&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>CodespacesListRepoSecrets200Response</returns>
        CodespacesListRepoSecrets200Response CodespacesListRepoSecrets (string owner, string repo, int? perPage, int? page);
        /// <summary>
        /// List selected repositories for a user secret List the repositories that have been granted the ability to use a user&#39;s codespace secret.  You must authenticate using an access token with the &#x60;codespace&#x60; or &#x60;codespace:secrets&#x60; scope to use this endpoint. User must have Codespaces access to use this endpoint.  GitHub Apps must have read access to the &#x60;codespaces_user_secrets&#x60; user permission and write access to the &#x60;codespaces_secrets&#x60; repository permission on all referenced repositories to use this endpoint.
        /// </summary>
        /// <param name="secretName">The name of the secret.</param>
        /// <returns>ActionsListSelectedReposForOrgSecret200Response</returns>
        ActionsListSelectedReposForOrgSecret200Response CodespacesListRepositoriesForSecretForAuthenticatedUser (string secretName);
        /// <summary>
        /// List secrets for the authenticated user Lists all secrets available for a user&#39;s Codespaces without revealing their encrypted values.  You must authenticate using an access token with the &#x60;codespace&#x60; or &#x60;codespace:secrets&#x60; scope to use this endpoint. User must have Codespaces access to use this endpoint.  GitHub Apps must have read access to the &#x60;codespaces_user_secrets&#x60; user permission to use this endpoint.
        /// </summary>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>CodespacesListSecretsForAuthenticatedUser200Response</returns>
        CodespacesListSecretsForAuthenticatedUser200Response CodespacesListSecretsForAuthenticatedUser (int? perPage, int? page);
        /// <summary>
        /// Get default attributes for a codespace Gets the default attributes for codespaces created by the user with the repository.  You must authenticate using an access token with the &#x60;codespace&#x60; scope to use this endpoint.  GitHub Apps must have write access to the &#x60;codespaces&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="_ref">The branch or commit to check for a default devcontainer path. If not specified, the default branch will be checked.</param>
        /// <param name="clientIp">An alternative IP for default location auto-detection, such as when proxying a request.</param>
        /// <returns>CodespacesPreFlightWithRepoForAuthenticatedUser200Response</returns>
        CodespacesPreFlightWithRepoForAuthenticatedUser200Response CodespacesPreFlightWithRepoForAuthenticatedUser (string owner, string repo, string _ref, string clientIp);
        /// <summary>
        /// Remove a selected repository from a user secret Removes a repository from the selected repositories for a user&#39;s codespace secret. You must authenticate using an access token with the &#x60;codespace&#x60; or &#x60;codespace:secrets&#x60; scope to use this endpoint. User must have Codespaces access to use this endpoint. GitHub Apps must have write access to the &#x60;codespaces_user_secrets&#x60; user permission to use this endpoint.
        /// </summary>
        /// <param name="secretName">The name of the secret.</param>
        /// <param name="repositoryId"></param>
        /// <returns></returns>
        void CodespacesRemoveRepositoryForSecretForAuthenticatedUser (string secretName, int? repositoryId);
        /// <summary>
        /// List available machine types for a repository List the machine types available for a given repository based on its configuration.  You must authenticate using an access token with the &#x60;codespace&#x60; scope to use this endpoint.  GitHub Apps must have write access to the &#x60;codespaces_metadata&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="location">The location to check for available machines. Assigned by IP if not provided.</param>
        /// <param name="clientIp">IP for location auto-detection when proxying a request</param>
        /// <returns>CodespacesRepoMachinesForAuthenticatedUser200Response</returns>
        CodespacesRepoMachinesForAuthenticatedUser200Response CodespacesRepoMachinesForAuthenticatedUser (string owner, string repo, string location, string clientIp);
        /// <summary>
        /// Set selected repositories for a user secret Select the repositories that will use a user&#39;s codespace secret.  You must authenticate using an access token with the &#x60;codespace&#x60; or &#x60;codespace:secrets&#x60; scope to use this endpoint. User must have Codespaces access to use this endpoint.  GitHub Apps must have write access to the &#x60;codespaces_user_secrets&#x60; user permission and write access to the &#x60;codespaces_secrets&#x60; repository permission on all referenced repositories to use this endpoint.
        /// </summary>
        /// <param name="secretName">The name of the secret.</param>
        /// <param name="codespacesSetRepositoriesForSecretForAuthenticatedUserRequest"></param>
        /// <returns></returns>
        void CodespacesSetRepositoriesForSecretForAuthenticatedUser (string secretName, CodespacesSetRepositoriesForSecretForAuthenticatedUserRequest codespacesSetRepositoriesForSecretForAuthenticatedUserRequest);
        /// <summary>
        /// Start a codespace for the authenticated user Starts a user&#39;s codespace.  You must authenticate using an access token with the &#x60;codespace&#x60; scope to use this endpoint.  GitHub Apps must have write access to the &#x60;codespaces_lifecycle_admin&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="codespaceName">The name of the codespace.</param>
        /// <returns>Codespace</returns>
        Codespace CodespacesStartForAuthenticatedUser (string codespaceName);
        /// <summary>
        /// Stop a codespace for the authenticated user Stops a user&#39;s codespace.  You must authenticate using an access token with the &#x60;codespace&#x60; scope to use this endpoint.  GitHub Apps must have write access to the &#x60;codespaces_lifecycle_admin&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="codespaceName">The name of the codespace.</param>
        /// <returns>Codespace</returns>
        Codespace CodespacesStopForAuthenticatedUser (string codespaceName);
        /// <summary>
        /// Stop a codespace for an organization user Stops a user&#39;s codespace.  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <param name="codespaceName">The name of the codespace.</param>
        /// <returns>Codespace</returns>
        Codespace CodespacesStopInOrganization (string org, string username, string codespaceName);
        /// <summary>
        /// Update a codespace for the authenticated user Updates a codespace owned by the authenticated user. Currently only the codespace&#39;s machine type and recent folders can be modified using this endpoint.  If you specify a new machine type it will be applied the next time your codespace is started.  You must authenticate using an access token with the &#x60;codespace&#x60; scope to use this endpoint.  GitHub Apps must have write access to the &#x60;codespaces&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="codespaceName">The name of the codespace.</param>
        /// <param name="codespacesUpdateForAuthenticatedUserRequest"></param>
        /// <returns>Codespace</returns>
        Codespace CodespacesUpdateForAuthenticatedUser (string codespaceName, CodespacesUpdateForAuthenticatedUserRequest codespacesUpdateForAuthenticatedUserRequest);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CodespacesApi : ICodespacesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CodespacesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public CodespacesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodespacesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CodespacesApi(String basePath)
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
        /// Add a selected repository to a user secret Adds a repository to the selected repositories for a user&#39;s codespace secret. You must authenticate using an access token with the &#x60;codespace&#x60; or &#x60;codespace:secrets&#x60; scope to use this endpoint. User must have Codespaces access to use this endpoint. GitHub Apps must have write access to the &#x60;codespaces_user_secrets&#x60; user permission and write access to the &#x60;codespaces_secrets&#x60; repository permission on the referenced repository to use this endpoint.
        /// </summary>
        /// <param name="secretName">The name of the secret.</param>
        /// <param name="repositoryId"></param>
        /// <returns></returns>
        public void CodespacesAddRepositoryForSecretForAuthenticatedUser (string secretName, int? repositoryId)
        {
            
            // verify the required parameter 'secretName' is set
            if (secretName == null) throw new ApiException(400, "Missing required parameter 'secretName' when calling CodespacesAddRepositoryForSecretForAuthenticatedUser");
            
            // verify the required parameter 'repositoryId' is set
            if (repositoryId == null) throw new ApiException(400, "Missing required parameter 'repositoryId' when calling CodespacesAddRepositoryForSecretForAuthenticatedUser");
            

            var path = "/user/codespaces/secrets/{secret_name}/repositories/{repository_id}";
            path = path.Replace("{format}", "json");
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
                throw new ApiException ((int)response.StatusCode, "Error calling CodespacesAddRepositoryForSecretForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CodespacesAddRepositoryForSecretForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// List machine types for a codespace List the machine types a codespace can transition to use.  You must authenticate using an access token with the &#x60;codespace&#x60; scope to use this endpoint.  GitHub Apps must have read access to the &#x60;codespaces_metadata&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="codespaceName">The name of the codespace.</param>
        /// <returns>CodespacesRepoMachinesForAuthenticatedUser200Response</returns>
        public CodespacesRepoMachinesForAuthenticatedUser200Response CodespacesCodespaceMachinesForAuthenticatedUser (string codespaceName)
        {
            
            // verify the required parameter 'codespaceName' is set
            if (codespaceName == null) throw new ApiException(400, "Missing required parameter 'codespaceName' when calling CodespacesCodespaceMachinesForAuthenticatedUser");
            

            var path = "/user/codespaces/{codespace_name}/machines";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "codespace_name" + "}", ApiClient.ParameterToString(codespaceName));

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
                throw new ApiException ((int)response.StatusCode, "Error calling CodespacesCodespaceMachinesForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CodespacesCodespaceMachinesForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return (CodespacesRepoMachinesForAuthenticatedUser200Response) ApiClient.Deserialize(response.Content, typeof(CodespacesRepoMachinesForAuthenticatedUser200Response), response.Headers);
        }

        /// <summary>
        /// Create a codespace for the authenticated user Creates a new codespace, owned by the authenticated user.  This endpoint requires either a &#x60;repository_id&#x60; OR a &#x60;pull_request&#x60; but not both.  You must authenticate using an access token with the &#x60;codespace&#x60; scope to use this endpoint.  GitHub Apps must have write access to the &#x60;codespaces&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="codespacesCreateForAuthenticatedUserRequest"></param>
        /// <returns>Codespace</returns>
        public Codespace CodespacesCreateForAuthenticatedUser (CodespacesCreateForAuthenticatedUserRequest codespacesCreateForAuthenticatedUserRequest)
        {
            
            // verify the required parameter 'codespacesCreateForAuthenticatedUserRequest' is set
            if (codespacesCreateForAuthenticatedUserRequest == null) throw new ApiException(400, "Missing required parameter 'codespacesCreateForAuthenticatedUserRequest' when calling CodespacesCreateForAuthenticatedUser");
            

            var path = "/user/codespaces";
            path = path.Replace("{format}", "json");
            
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(codespacesCreateForAuthenticatedUserRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CodespacesCreateForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CodespacesCreateForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return (Codespace) ApiClient.Deserialize(response.Content, typeof(Codespace), response.Headers);
        }

        /// <summary>
        /// Create or update a repository secret Creates or updates a repository secret with an encrypted value. Encrypt your secret using [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages). You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;codespaces_secrets&#x60; repository permission to use this endpoint.  #### Example of encrypting a secret using Node.js  Encrypt your secret using the [tweetsodium](https://github.com/github/tweetsodium) library.  &#x60;&#x60;&#x60; const sodium &#x3D; require(&#39;tweetsodium&#39;);  const key &#x3D; \&quot;base64-encoded-public-key\&quot;; const value &#x3D; \&quot;plain-text-secret\&quot;;  // Convert the message and key to Uint8Array&#39;s (Buffer implements that interface) const messageBytes &#x3D; Buffer.from(value); const keyBytes &#x3D; Buffer.from(key, &#39;base64&#39;);  // Encrypt using LibSodium. const encryptedBytes &#x3D; sodium.seal(messageBytes, keyBytes);  // Base64 the encrypted secret const encrypted &#x3D; Buffer.from(encryptedBytes).toString(&#39;base64&#39;);  console.log(encrypted); &#x60;&#x60;&#x60;   #### Example of encrypting a secret using Python  Encrypt your secret using [pynacl](https://pynacl.readthedocs.io/en/latest/public/#nacl-public-sealedbox) with Python 3.  &#x60;&#x60;&#x60; from base64 import b64encode from nacl import encoding, public  def encrypt(public_key: str, secret_value: str) -&gt; str:   \&quot;\&quot;\&quot;Encrypt a Unicode string using the public key.\&quot;\&quot;\&quot;   public_key &#x3D; public.PublicKey(public_key.encode(\&quot;utf-8\&quot;), encoding.Base64Encoder())   sealed_box &#x3D; public.SealedBox(public_key)   encrypted &#x3D; sealed_box.encrypt(secret_value.encode(\&quot;utf-8\&quot;))   return b64encode(encrypted).decode(\&quot;utf-8\&quot;) &#x60;&#x60;&#x60;  #### Example of encrypting a secret using C#  Encrypt your secret using the [Sodium.Core](https://www.nuget.org/packages/Sodium.Core/) package.  &#x60;&#x60;&#x60; var secretValue &#x3D; System.Text.Encoding.UTF8.GetBytes(\&quot;mySecret\&quot;); var publicKey &#x3D; Convert.FromBase64String(\&quot;2Sg8iYjAxxmI2LvUXpJjkYrMxURPc8r+dB7TJyvvcCU&#x3D;\&quot;);  var sealedPublicKeyBox &#x3D; Sodium.SealedPublicKeyBox.Create(secretValue, publicKey);  Console.WriteLine(Convert.ToBase64String(sealedPublicKeyBox)); &#x60;&#x60;&#x60;  #### Example of encrypting a secret using Ruby  Encrypt your secret using the [rbnacl](https://github.com/RubyCrypto/rbnacl) gem.  &#x60;&#x60;&#x60;ruby require \&quot;rbnacl\&quot; require \&quot;base64\&quot;  key &#x3D; Base64.decode64(\&quot;+ZYvJDZMHUfBkJdyq5Zm9SKqeuBQ4sj+6sfjlH4CgG0&#x3D;\&quot;) public_key &#x3D; RbNaCl::PublicKey.new(key)  box &#x3D; RbNaCl::Boxes::Sealed.from_public_key(public_key) encrypted_secret &#x3D; box.encrypt(\&quot;my_secret\&quot;)  # Print the base64 encoded secret puts Base64.strict_encode64(encrypted_secret) &#x60;&#x60;&#x60;
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="secretName">The name of the secret.</param>
        /// <param name="codespacesCreateOrUpdateRepoSecretRequest"></param>
        /// <returns>Object</returns>
        public Object CodespacesCreateOrUpdateRepoSecret (string owner, string repo, string secretName, CodespacesCreateOrUpdateRepoSecretRequest codespacesCreateOrUpdateRepoSecretRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling CodespacesCreateOrUpdateRepoSecret");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling CodespacesCreateOrUpdateRepoSecret");
            
            // verify the required parameter 'secretName' is set
            if (secretName == null) throw new ApiException(400, "Missing required parameter 'secretName' when calling CodespacesCreateOrUpdateRepoSecret");
            
            // verify the required parameter 'codespacesCreateOrUpdateRepoSecretRequest' is set
            if (codespacesCreateOrUpdateRepoSecretRequest == null) throw new ApiException(400, "Missing required parameter 'codespacesCreateOrUpdateRepoSecretRequest' when calling CodespacesCreateOrUpdateRepoSecret");
            

            var path = "/repos/{owner}/{repo}/codespaces/secrets/{secret_name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "secret_name" + "}", ApiClient.ParameterToString(secretName));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(codespacesCreateOrUpdateRepoSecretRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CodespacesCreateOrUpdateRepoSecret: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CodespacesCreateOrUpdateRepoSecret: " + response.ErrorMessage, response.ErrorMessage);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }

        /// <summary>
        /// Create or update a secret for the authenticated user Creates or updates a secret for a user&#39;s codespace with an encrypted value. Encrypt your secret using [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages).  You must authenticate using an access token with the &#x60;codespace&#x60; or &#x60;codespace:secrets&#x60; scope to use this endpoint. User must also have Codespaces access to use this endpoint.  GitHub Apps must have read access to the &#x60;codespaces_user_secrets&#x60; user permission and &#x60;codespaces_secrets&#x60; repository permission on all referenced repositories to use this endpoint.  #### Example encrypting a secret using Node.js  Encrypt your secret using the [tweetsodium](https://github.com/github/tweetsodium) library.  &#x60;&#x60;&#x60; const sodium &#x3D; require(&#39;tweetsodium&#39;);  const key &#x3D; \&quot;base64-encoded-public-key\&quot;; const value &#x3D; \&quot;plain-text-secret\&quot;;  // Convert the message and key to Uint8Array&#39;s (Buffer implements that interface) const messageBytes &#x3D; Buffer.from(value); const keyBytes &#x3D; Buffer.from(key, &#39;base64&#39;);  // Encrypt using LibSodium. const encryptedBytes &#x3D; sodium.seal(messageBytes, keyBytes);  // Base64 the encrypted secret const encrypted &#x3D; Buffer.from(encryptedBytes).toString(&#39;base64&#39;);  console.log(encrypted); &#x60;&#x60;&#x60;   #### Example encrypting a secret using Python  Encrypt your secret using [pynacl](https://pynacl.readthedocs.io/en/latest/public/#nacl-public-sealedbox) with Python 3.  &#x60;&#x60;&#x60; from base64 import b64encode from nacl import encoding, public  def encrypt(public_key: str, secret_value: str) -&gt; str:   \&quot;\&quot;\&quot;Encrypt a Unicode string using the public key.\&quot;\&quot;\&quot;   public_key &#x3D; public.PublicKey(public_key.encode(\&quot;utf-8\&quot;), encoding.Base64Encoder())   sealed_box &#x3D; public.SealedBox(public_key)   encrypted &#x3D; sealed_box.encrypt(secret_value.encode(\&quot;utf-8\&quot;))   return b64encode(encrypted).decode(\&quot;utf-8\&quot;) &#x60;&#x60;&#x60;  #### Example encrypting a secret using C#  Encrypt your secret using the [Sodium.Core](https://www.nuget.org/packages/Sodium.Core/) package.  &#x60;&#x60;&#x60; var secretValue &#x3D; System.Text.Encoding.UTF8.GetBytes(\&quot;mySecret\&quot;); var publicKey &#x3D; Convert.FromBase64String(\&quot;2Sg8iYjAxxmI2LvUXpJjkYrMxURPc8r+dB7TJyvvcCU&#x3D;\&quot;);  var sealedPublicKeyBox &#x3D; Sodium.SealedPublicKeyBox.Create(secretValue, publicKey);  Console.WriteLine(Convert.ToBase64String(sealedPublicKeyBox)); &#x60;&#x60;&#x60;  #### Example encrypting a secret using Ruby  Encrypt your secret using the [rbnacl](https://github.com/RubyCrypto/rbnacl) gem.  &#x60;&#x60;&#x60;ruby require \&quot;rbnacl\&quot; require \&quot;base64\&quot;  key &#x3D; Base64.decode64(\&quot;+ZYvJDZMHUfBkJdyq5Zm9SKqeuBQ4sj+6sfjlH4CgG0&#x3D;\&quot;) public_key &#x3D; RbNaCl::PublicKey.new(key)  box &#x3D; RbNaCl::Boxes::Sealed.from_public_key(public_key) encrypted_secret &#x3D; box.encrypt(\&quot;my_secret\&quot;)  # Print the base64 encoded secret puts Base64.strict_encode64(encrypted_secret) &#x60;&#x60;&#x60;
        /// </summary>
        /// <param name="secretName">The name of the secret.</param>
        /// <param name="codespacesCreateOrUpdateSecretForAuthenticatedUserRequest"></param>
        /// <returns>Object</returns>
        public Object CodespacesCreateOrUpdateSecretForAuthenticatedUser (string secretName, CodespacesCreateOrUpdateSecretForAuthenticatedUserRequest codespacesCreateOrUpdateSecretForAuthenticatedUserRequest)
        {
            
            // verify the required parameter 'secretName' is set
            if (secretName == null) throw new ApiException(400, "Missing required parameter 'secretName' when calling CodespacesCreateOrUpdateSecretForAuthenticatedUser");
            
            // verify the required parameter 'codespacesCreateOrUpdateSecretForAuthenticatedUserRequest' is set
            if (codespacesCreateOrUpdateSecretForAuthenticatedUserRequest == null) throw new ApiException(400, "Missing required parameter 'codespacesCreateOrUpdateSecretForAuthenticatedUserRequest' when calling CodespacesCreateOrUpdateSecretForAuthenticatedUser");
            

            var path = "/user/codespaces/secrets/{secret_name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "secret_name" + "}", ApiClient.ParameterToString(secretName));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(codespacesCreateOrUpdateSecretForAuthenticatedUserRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CodespacesCreateOrUpdateSecretForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CodespacesCreateOrUpdateSecretForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }

        /// <summary>
        /// Create a codespace from a pull request Creates a codespace owned by the authenticated user for the specified pull request.  You must authenticate using an access token with the &#x60;codespace&#x60; scope to use this endpoint.  GitHub Apps must have write access to the &#x60;codespaces&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="pullNumber">The number that identifies the pull request.</param>
        /// <param name="codespacesCreateWithPrForAuthenticatedUserRequest"></param>
        /// <returns>Codespace</returns>
        public Codespace CodespacesCreateWithPrForAuthenticatedUser (string owner, string repo, int? pullNumber, CodespacesCreateWithPrForAuthenticatedUserRequest codespacesCreateWithPrForAuthenticatedUserRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling CodespacesCreateWithPrForAuthenticatedUser");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling CodespacesCreateWithPrForAuthenticatedUser");
            
            // verify the required parameter 'pullNumber' is set
            if (pullNumber == null) throw new ApiException(400, "Missing required parameter 'pullNumber' when calling CodespacesCreateWithPrForAuthenticatedUser");
            
            // verify the required parameter 'codespacesCreateWithPrForAuthenticatedUserRequest' is set
            if (codespacesCreateWithPrForAuthenticatedUserRequest == null) throw new ApiException(400, "Missing required parameter 'codespacesCreateWithPrForAuthenticatedUserRequest' when calling CodespacesCreateWithPrForAuthenticatedUser");
            

            var path = "/repos/{owner}/{repo}/pulls/{pull_number}/codespaces";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "pull_number" + "}", ApiClient.ParameterToString(pullNumber));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(codespacesCreateWithPrForAuthenticatedUserRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CodespacesCreateWithPrForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CodespacesCreateWithPrForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return (Codespace) ApiClient.Deserialize(response.Content, typeof(Codespace), response.Headers);
        }

        /// <summary>
        /// Create a codespace in a repository Creates a codespace owned by the authenticated user in the specified repository.  You must authenticate using an access token with the &#x60;codespace&#x60; scope to use this endpoint.  GitHub Apps must have write access to the &#x60;codespaces&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="codespacesCreateWithRepoForAuthenticatedUserRequest"></param>
        /// <returns>Codespace</returns>
        public Codespace CodespacesCreateWithRepoForAuthenticatedUser (string owner, string repo, CodespacesCreateWithRepoForAuthenticatedUserRequest codespacesCreateWithRepoForAuthenticatedUserRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling CodespacesCreateWithRepoForAuthenticatedUser");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling CodespacesCreateWithRepoForAuthenticatedUser");
            
            // verify the required parameter 'codespacesCreateWithRepoForAuthenticatedUserRequest' is set
            if (codespacesCreateWithRepoForAuthenticatedUserRequest == null) throw new ApiException(400, "Missing required parameter 'codespacesCreateWithRepoForAuthenticatedUserRequest' when calling CodespacesCreateWithRepoForAuthenticatedUser");
            

            var path = "/repos/{owner}/{repo}/codespaces";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(codespacesCreateWithRepoForAuthenticatedUserRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CodespacesCreateWithRepoForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CodespacesCreateWithRepoForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return (Codespace) ApiClient.Deserialize(response.Content, typeof(Codespace), response.Headers);
        }

        /// <summary>
        /// Delete a codespace for the authenticated user Deletes a user&#39;s codespace.  You must authenticate using an access token with the &#x60;codespace&#x60; scope to use this endpoint.  GitHub Apps must have write access to the &#x60;codespaces&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="codespaceName">The name of the codespace.</param>
        /// <returns>Object</returns>
        public Object CodespacesDeleteForAuthenticatedUser (string codespaceName)
        {
            
            // verify the required parameter 'codespaceName' is set
            if (codespaceName == null) throw new ApiException(400, "Missing required parameter 'codespaceName' when calling CodespacesDeleteForAuthenticatedUser");
            

            var path = "/user/codespaces/{codespace_name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "codespace_name" + "}", ApiClient.ParameterToString(codespaceName));

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
                throw new ApiException ((int)response.StatusCode, "Error calling CodespacesDeleteForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CodespacesDeleteForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }

        /// <summary>
        /// Delete a codespace from the organization Deletes a user&#39;s codespace.  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <param name="codespaceName">The name of the codespace.</param>
        /// <returns>Object</returns>
        public Object CodespacesDeleteFromOrganization (string org, string username, string codespaceName)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling CodespacesDeleteFromOrganization");
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling CodespacesDeleteFromOrganization");
            
            // verify the required parameter 'codespaceName' is set
            if (codespaceName == null) throw new ApiException(400, "Missing required parameter 'codespaceName' when calling CodespacesDeleteFromOrganization");
            

            var path = "/orgs/{org}/members/{username}/codespaces/{codespace_name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "username" + "}", ApiClient.ParameterToString(username));
path = path.Replace("{" + "codespace_name" + "}", ApiClient.ParameterToString(codespaceName));

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
                throw new ApiException ((int)response.StatusCode, "Error calling CodespacesDeleteFromOrganization: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CodespacesDeleteFromOrganization: " + response.ErrorMessage, response.ErrorMessage);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }

        /// <summary>
        /// Delete a repository secret Deletes a secret in a repository using the secret name. You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;codespaces_secrets&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="secretName">The name of the secret.</param>
        /// <returns></returns>
        public void CodespacesDeleteRepoSecret (string owner, string repo, string secretName)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling CodespacesDeleteRepoSecret");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling CodespacesDeleteRepoSecret");
            
            // verify the required parameter 'secretName' is set
            if (secretName == null) throw new ApiException(400, "Missing required parameter 'secretName' when calling CodespacesDeleteRepoSecret");
            

            var path = "/repos/{owner}/{repo}/codespaces/secrets/{secret_name}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CodespacesDeleteRepoSecret: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CodespacesDeleteRepoSecret: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Delete a secret for the authenticated user Deletes a secret from a user&#39;s codespaces using the secret name. Deleting the secret will remove access from all codespaces that were allowed to access the secret.  You must authenticate using an access token with the &#x60;codespace&#x60; or &#x60;codespace:secrets&#x60; scope to use this endpoint. User must have Codespaces access to use this endpoint.  GitHub Apps must have write access to the &#x60;codespaces_user_secrets&#x60; user permission to use this endpoint.
        /// </summary>
        /// <param name="secretName">The name of the secret.</param>
        /// <returns></returns>
        public void CodespacesDeleteSecretForAuthenticatedUser (string secretName)
        {
            
            // verify the required parameter 'secretName' is set
            if (secretName == null) throw new ApiException(400, "Missing required parameter 'secretName' when calling CodespacesDeleteSecretForAuthenticatedUser");
            

            var path = "/user/codespaces/secrets/{secret_name}";
            path = path.Replace("{format}", "json");
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
                throw new ApiException ((int)response.StatusCode, "Error calling CodespacesDeleteSecretForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CodespacesDeleteSecretForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Export a codespace for the authenticated user Triggers an export of the specified codespace and returns a URL and ID where the status of the export can be monitored.  You must authenticate using a personal access token with the &#x60;codespace&#x60; scope to use this endpoint.  GitHub Apps must have write access to the &#x60;codespaces_lifecycle_admin&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="codespaceName">The name of the codespace.</param>
        /// <returns>FetchesInformationAboutAnExportOfACodespace</returns>
        public FetchesInformationAboutAnExportOfACodespace CodespacesExportForAuthenticatedUser (string codespaceName)
        {
            
            // verify the required parameter 'codespaceName' is set
            if (codespaceName == null) throw new ApiException(400, "Missing required parameter 'codespaceName' when calling CodespacesExportForAuthenticatedUser");
            

            var path = "/user/codespaces/{codespace_name}/exports";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "codespace_name" + "}", ApiClient.ParameterToString(codespaceName));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CodespacesExportForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CodespacesExportForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return (FetchesInformationAboutAnExportOfACodespace) ApiClient.Deserialize(response.Content, typeof(FetchesInformationAboutAnExportOfACodespace), response.Headers);
        }

        /// <summary>
        /// Get details about a codespace export Gets information about an export of a codespace.  You must authenticate using a personal access token with the &#x60;codespace&#x60; scope to use this endpoint.  GitHub Apps must have read access to the &#x60;codespaces_lifecycle_admin&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="codespaceName">The name of the codespace.</param>
        /// <param name="exportId">The ID of the export operation, or &#x60;latest&#x60;. Currently only &#x60;latest&#x60; is currently supported.</param>
        /// <returns>FetchesInformationAboutAnExportOfACodespace</returns>
        public FetchesInformationAboutAnExportOfACodespace CodespacesGetExportDetailsForAuthenticatedUser (string codespaceName, string exportId)
        {
            
            // verify the required parameter 'codespaceName' is set
            if (codespaceName == null) throw new ApiException(400, "Missing required parameter 'codespaceName' when calling CodespacesGetExportDetailsForAuthenticatedUser");
            
            // verify the required parameter 'exportId' is set
            if (exportId == null) throw new ApiException(400, "Missing required parameter 'exportId' when calling CodespacesGetExportDetailsForAuthenticatedUser");
            

            var path = "/user/codespaces/{codespace_name}/exports/{export_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "codespace_name" + "}", ApiClient.ParameterToString(codespaceName));
path = path.Replace("{" + "export_id" + "}", ApiClient.ParameterToString(exportId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling CodespacesGetExportDetailsForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CodespacesGetExportDetailsForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return (FetchesInformationAboutAnExportOfACodespace) ApiClient.Deserialize(response.Content, typeof(FetchesInformationAboutAnExportOfACodespace), response.Headers);
        }

        /// <summary>
        /// Get a codespace for the authenticated user Gets information about a user&#39;s codespace.  You must authenticate using an access token with the &#x60;codespace&#x60; scope to use this endpoint.  GitHub Apps must have read access to the &#x60;codespaces&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="codespaceName">The name of the codespace.</param>
        /// <returns>Codespace</returns>
        public Codespace CodespacesGetForAuthenticatedUser (string codespaceName)
        {
            
            // verify the required parameter 'codespaceName' is set
            if (codespaceName == null) throw new ApiException(400, "Missing required parameter 'codespaceName' when calling CodespacesGetForAuthenticatedUser");
            

            var path = "/user/codespaces/{codespace_name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "codespace_name" + "}", ApiClient.ParameterToString(codespaceName));

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
                throw new ApiException ((int)response.StatusCode, "Error calling CodespacesGetForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CodespacesGetForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return (Codespace) ApiClient.Deserialize(response.Content, typeof(Codespace), response.Headers);
        }

        /// <summary>
        /// Get public key for the authenticated user Gets your public key, which you need to encrypt secrets. You need to encrypt a secret before you can create or update secrets.  You must authenticate using an access token with the &#x60;codespace&#x60; or &#x60;codespace:secrets&#x60; scope to use this endpoint. User must have Codespaces access to use this endpoint.  GitHub Apps must have read access to the &#x60;codespaces_user_secrets&#x60; user permission to use this endpoint.
        /// </summary>
        /// <returns>CodespacesUserPublicKey</returns>
        public CodespacesUserPublicKey CodespacesGetPublicKeyForAuthenticatedUser ()
        {
            

            var path = "/user/codespaces/secrets/public-key";
            path = path.Replace("{format}", "json");
            
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
                throw new ApiException ((int)response.StatusCode, "Error calling CodespacesGetPublicKeyForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CodespacesGetPublicKeyForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return (CodespacesUserPublicKey) ApiClient.Deserialize(response.Content, typeof(CodespacesUserPublicKey), response.Headers);
        }

        /// <summary>
        /// Get a repository public key Gets your public key, which you need to encrypt secrets. You need to encrypt a secret before you can create or update secrets. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the &#x60;repo&#x60; scope. GitHub Apps must have the &#x60;codespaces_secrets&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>CodespacesPublicKey</returns>
        public CodespacesPublicKey CodespacesGetRepoPublicKey (string owner, string repo)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling CodespacesGetRepoPublicKey");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling CodespacesGetRepoPublicKey");
            

            var path = "/repos/{owner}/{repo}/codespaces/secrets/public-key";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CodespacesGetRepoPublicKey: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CodespacesGetRepoPublicKey: " + response.ErrorMessage, response.ErrorMessage);

            return (CodespacesPublicKey) ApiClient.Deserialize(response.Content, typeof(CodespacesPublicKey), response.Headers);
        }

        /// <summary>
        /// Get a repository secret Gets a single repository secret without revealing its encrypted value. You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;codespaces_secrets&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="secretName">The name of the secret.</param>
        /// <returns>CodespacesSecret</returns>
        public CodespacesSecret CodespacesGetRepoSecret (string owner, string repo, string secretName)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling CodespacesGetRepoSecret");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling CodespacesGetRepoSecret");
            
            // verify the required parameter 'secretName' is set
            if (secretName == null) throw new ApiException(400, "Missing required parameter 'secretName' when calling CodespacesGetRepoSecret");
            

            var path = "/repos/{owner}/{repo}/codespaces/secrets/{secret_name}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CodespacesGetRepoSecret: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CodespacesGetRepoSecret: " + response.ErrorMessage, response.ErrorMessage);

            return (CodespacesSecret) ApiClient.Deserialize(response.Content, typeof(CodespacesSecret), response.Headers);
        }

        /// <summary>
        /// Get a secret for the authenticated user Gets a secret available to a user&#39;s codespaces without revealing its encrypted value.  You must authenticate using an access token with the &#x60;codespace&#x60; or &#x60;codespace:secrets&#x60; scope to use this endpoint. User must have Codespaces access to use this endpoint.  GitHub Apps must have read access to the &#x60;codespaces_user_secrets&#x60; user permission to use this endpoint.
        /// </summary>
        /// <param name="secretName">The name of the secret.</param>
        /// <returns>CodespacesSecret1</returns>
        public CodespacesSecret1 CodespacesGetSecretForAuthenticatedUser (string secretName)
        {
            
            // verify the required parameter 'secretName' is set
            if (secretName == null) throw new ApiException(400, "Missing required parameter 'secretName' when calling CodespacesGetSecretForAuthenticatedUser");
            

            var path = "/user/codespaces/secrets/{secret_name}";
            path = path.Replace("{format}", "json");
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
                throw new ApiException ((int)response.StatusCode, "Error calling CodespacesGetSecretForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CodespacesGetSecretForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return (CodespacesSecret1) ApiClient.Deserialize(response.Content, typeof(CodespacesSecret1), response.Headers);
        }

        /// <summary>
        /// List devcontainer configurations in a repository for the authenticated user Lists the devcontainer.json files associated with a specified repository and the authenticated user. These files specify launchpoint configurations for codespaces created within the repository.  You must authenticate using an access token with the &#x60;codespace&#x60; scope to use this endpoint.  GitHub Apps must have read access to the &#x60;codespaces_metadata&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>CodespacesListDevcontainersInRepositoryForAuthenticatedUser200Response</returns>
        public CodespacesListDevcontainersInRepositoryForAuthenticatedUser200Response CodespacesListDevcontainersInRepositoryForAuthenticatedUser (string owner, string repo, int? perPage, int? page)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling CodespacesListDevcontainersInRepositoryForAuthenticatedUser");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling CodespacesListDevcontainersInRepositoryForAuthenticatedUser");
            

            var path = "/repos/{owner}/{repo}/codespaces/devcontainers";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CodespacesListDevcontainersInRepositoryForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CodespacesListDevcontainersInRepositoryForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return (CodespacesListDevcontainersInRepositoryForAuthenticatedUser200Response) ApiClient.Deserialize(response.Content, typeof(CodespacesListDevcontainersInRepositoryForAuthenticatedUser200Response), response.Headers);
        }

        /// <summary>
        /// List codespaces for the authenticated user Lists the authenticated user&#39;s codespaces.  You must authenticate using an access token with the &#x60;codespace&#x60; scope to use this endpoint.  GitHub Apps must have read access to the &#x60;codespaces&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <param name="repositoryId">ID of the Repository to filter on</param>
        /// <returns>CodespacesListInOrganization200Response</returns>
        public CodespacesListInOrganization200Response CodespacesListForAuthenticatedUser (int? perPage, int? page, int? repositoryId)
        {
            

            var path = "/user/codespaces";
            path = path.Replace("{format}", "json");
            
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (repositoryId != null) queryParams.Add("repository_id", ApiClient.ParameterToString(repositoryId)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CodespacesListForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CodespacesListForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return (CodespacesListInOrganization200Response) ApiClient.Deserialize(response.Content, typeof(CodespacesListInOrganization200Response), response.Headers);
        }

        /// <summary>
        /// List codespaces for the organization Lists the codespaces associated to a specified organization.  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>CodespacesListInOrganization200Response</returns>
        public CodespacesListInOrganization200Response CodespacesListInOrganization (string org, int? perPage, int? page)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling CodespacesListInOrganization");
            

            var path = "/orgs/{org}/codespaces";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CodespacesListInOrganization: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CodespacesListInOrganization: " + response.ErrorMessage, response.ErrorMessage);

            return (CodespacesListInOrganization200Response) ApiClient.Deserialize(response.Content, typeof(CodespacesListInOrganization200Response), response.Headers);
        }

        /// <summary>
        /// List codespaces in a repository for the authenticated user Lists the codespaces associated to a specified repository and the authenticated user.  You must authenticate using an access token with the &#x60;codespace&#x60; scope to use this endpoint.  GitHub Apps must have read access to the &#x60;codespaces&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>CodespacesListInOrganization200Response</returns>
        public CodespacesListInOrganization200Response CodespacesListInRepositoryForAuthenticatedUser (string owner, string repo, int? perPage, int? page)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling CodespacesListInRepositoryForAuthenticatedUser");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling CodespacesListInRepositoryForAuthenticatedUser");
            

            var path = "/repos/{owner}/{repo}/codespaces";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CodespacesListInRepositoryForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CodespacesListInRepositoryForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return (CodespacesListInOrganization200Response) ApiClient.Deserialize(response.Content, typeof(CodespacesListInOrganization200Response), response.Headers);
        }

        /// <summary>
        /// List repository secrets Lists all secrets available in a repository without revealing their encrypted values. You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;codespaces_secrets&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>CodespacesListRepoSecrets200Response</returns>
        public CodespacesListRepoSecrets200Response CodespacesListRepoSecrets (string owner, string repo, int? perPage, int? page)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling CodespacesListRepoSecrets");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling CodespacesListRepoSecrets");
            

            var path = "/repos/{owner}/{repo}/codespaces/secrets";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CodespacesListRepoSecrets: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CodespacesListRepoSecrets: " + response.ErrorMessage, response.ErrorMessage);

            return (CodespacesListRepoSecrets200Response) ApiClient.Deserialize(response.Content, typeof(CodespacesListRepoSecrets200Response), response.Headers);
        }

        /// <summary>
        /// List selected repositories for a user secret List the repositories that have been granted the ability to use a user&#39;s codespace secret.  You must authenticate using an access token with the &#x60;codespace&#x60; or &#x60;codespace:secrets&#x60; scope to use this endpoint. User must have Codespaces access to use this endpoint.  GitHub Apps must have read access to the &#x60;codespaces_user_secrets&#x60; user permission and write access to the &#x60;codespaces_secrets&#x60; repository permission on all referenced repositories to use this endpoint.
        /// </summary>
        /// <param name="secretName">The name of the secret.</param>
        /// <returns>ActionsListSelectedReposForOrgSecret200Response</returns>
        public ActionsListSelectedReposForOrgSecret200Response CodespacesListRepositoriesForSecretForAuthenticatedUser (string secretName)
        {
            
            // verify the required parameter 'secretName' is set
            if (secretName == null) throw new ApiException(400, "Missing required parameter 'secretName' when calling CodespacesListRepositoriesForSecretForAuthenticatedUser");
            

            var path = "/user/codespaces/secrets/{secret_name}/repositories";
            path = path.Replace("{format}", "json");
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
                throw new ApiException ((int)response.StatusCode, "Error calling CodespacesListRepositoriesForSecretForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CodespacesListRepositoriesForSecretForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return (ActionsListSelectedReposForOrgSecret200Response) ApiClient.Deserialize(response.Content, typeof(ActionsListSelectedReposForOrgSecret200Response), response.Headers);
        }

        /// <summary>
        /// List secrets for the authenticated user Lists all secrets available for a user&#39;s Codespaces without revealing their encrypted values.  You must authenticate using an access token with the &#x60;codespace&#x60; or &#x60;codespace:secrets&#x60; scope to use this endpoint. User must have Codespaces access to use this endpoint.  GitHub Apps must have read access to the &#x60;codespaces_user_secrets&#x60; user permission to use this endpoint.
        /// </summary>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>CodespacesListSecretsForAuthenticatedUser200Response</returns>
        public CodespacesListSecretsForAuthenticatedUser200Response CodespacesListSecretsForAuthenticatedUser (int? perPage, int? page)
        {
            

            var path = "/user/codespaces/secrets";
            path = path.Replace("{format}", "json");
            
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
                throw new ApiException ((int)response.StatusCode, "Error calling CodespacesListSecretsForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CodespacesListSecretsForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return (CodespacesListSecretsForAuthenticatedUser200Response) ApiClient.Deserialize(response.Content, typeof(CodespacesListSecretsForAuthenticatedUser200Response), response.Headers);
        }

        /// <summary>
        /// Get default attributes for a codespace Gets the default attributes for codespaces created by the user with the repository.  You must authenticate using an access token with the &#x60;codespace&#x60; scope to use this endpoint.  GitHub Apps must have write access to the &#x60;codespaces&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="_ref">The branch or commit to check for a default devcontainer path. If not specified, the default branch will be checked.</param>
        /// <param name="clientIp">An alternative IP for default location auto-detection, such as when proxying a request.</param>
        /// <returns>CodespacesPreFlightWithRepoForAuthenticatedUser200Response</returns>
        public CodespacesPreFlightWithRepoForAuthenticatedUser200Response CodespacesPreFlightWithRepoForAuthenticatedUser (string owner, string repo, string _ref, string clientIp)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling CodespacesPreFlightWithRepoForAuthenticatedUser");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling CodespacesPreFlightWithRepoForAuthenticatedUser");
            

            var path = "/repos/{owner}/{repo}/codespaces/new";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (_ref != null) queryParams.Add("ref", ApiClient.ParameterToString(_ref)); // query parameter
 if (clientIp != null) queryParams.Add("client_ip", ApiClient.ParameterToString(clientIp)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CodespacesPreFlightWithRepoForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CodespacesPreFlightWithRepoForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return (CodespacesPreFlightWithRepoForAuthenticatedUser200Response) ApiClient.Deserialize(response.Content, typeof(CodespacesPreFlightWithRepoForAuthenticatedUser200Response), response.Headers);
        }

        /// <summary>
        /// Remove a selected repository from a user secret Removes a repository from the selected repositories for a user&#39;s codespace secret. You must authenticate using an access token with the &#x60;codespace&#x60; or &#x60;codespace:secrets&#x60; scope to use this endpoint. User must have Codespaces access to use this endpoint. GitHub Apps must have write access to the &#x60;codespaces_user_secrets&#x60; user permission to use this endpoint.
        /// </summary>
        /// <param name="secretName">The name of the secret.</param>
        /// <param name="repositoryId"></param>
        /// <returns></returns>
        public void CodespacesRemoveRepositoryForSecretForAuthenticatedUser (string secretName, int? repositoryId)
        {
            
            // verify the required parameter 'secretName' is set
            if (secretName == null) throw new ApiException(400, "Missing required parameter 'secretName' when calling CodespacesRemoveRepositoryForSecretForAuthenticatedUser");
            
            // verify the required parameter 'repositoryId' is set
            if (repositoryId == null) throw new ApiException(400, "Missing required parameter 'repositoryId' when calling CodespacesRemoveRepositoryForSecretForAuthenticatedUser");
            

            var path = "/user/codespaces/secrets/{secret_name}/repositories/{repository_id}";
            path = path.Replace("{format}", "json");
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
                throw new ApiException ((int)response.StatusCode, "Error calling CodespacesRemoveRepositoryForSecretForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CodespacesRemoveRepositoryForSecretForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// List available machine types for a repository List the machine types available for a given repository based on its configuration.  You must authenticate using an access token with the &#x60;codespace&#x60; scope to use this endpoint.  GitHub Apps must have write access to the &#x60;codespaces_metadata&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="location">The location to check for available machines. Assigned by IP if not provided.</param>
        /// <param name="clientIp">IP for location auto-detection when proxying a request</param>
        /// <returns>CodespacesRepoMachinesForAuthenticatedUser200Response</returns>
        public CodespacesRepoMachinesForAuthenticatedUser200Response CodespacesRepoMachinesForAuthenticatedUser (string owner, string repo, string location, string clientIp)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling CodespacesRepoMachinesForAuthenticatedUser");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling CodespacesRepoMachinesForAuthenticatedUser");
            

            var path = "/repos/{owner}/{repo}/codespaces/machines";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (location != null) queryParams.Add("location", ApiClient.ParameterToString(location)); // query parameter
 if (clientIp != null) queryParams.Add("client_ip", ApiClient.ParameterToString(clientIp)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CodespacesRepoMachinesForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CodespacesRepoMachinesForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return (CodespacesRepoMachinesForAuthenticatedUser200Response) ApiClient.Deserialize(response.Content, typeof(CodespacesRepoMachinesForAuthenticatedUser200Response), response.Headers);
        }

        /// <summary>
        /// Set selected repositories for a user secret Select the repositories that will use a user&#39;s codespace secret.  You must authenticate using an access token with the &#x60;codespace&#x60; or &#x60;codespace:secrets&#x60; scope to use this endpoint. User must have Codespaces access to use this endpoint.  GitHub Apps must have write access to the &#x60;codespaces_user_secrets&#x60; user permission and write access to the &#x60;codespaces_secrets&#x60; repository permission on all referenced repositories to use this endpoint.
        /// </summary>
        /// <param name="secretName">The name of the secret.</param>
        /// <param name="codespacesSetRepositoriesForSecretForAuthenticatedUserRequest"></param>
        /// <returns></returns>
        public void CodespacesSetRepositoriesForSecretForAuthenticatedUser (string secretName, CodespacesSetRepositoriesForSecretForAuthenticatedUserRequest codespacesSetRepositoriesForSecretForAuthenticatedUserRequest)
        {
            
            // verify the required parameter 'secretName' is set
            if (secretName == null) throw new ApiException(400, "Missing required parameter 'secretName' when calling CodespacesSetRepositoriesForSecretForAuthenticatedUser");
            
            // verify the required parameter 'codespacesSetRepositoriesForSecretForAuthenticatedUserRequest' is set
            if (codespacesSetRepositoriesForSecretForAuthenticatedUserRequest == null) throw new ApiException(400, "Missing required parameter 'codespacesSetRepositoriesForSecretForAuthenticatedUserRequest' when calling CodespacesSetRepositoriesForSecretForAuthenticatedUser");
            

            var path = "/user/codespaces/secrets/{secret_name}/repositories";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "secret_name" + "}", ApiClient.ParameterToString(secretName));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(codespacesSetRepositoriesForSecretForAuthenticatedUserRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CodespacesSetRepositoriesForSecretForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CodespacesSetRepositoriesForSecretForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Start a codespace for the authenticated user Starts a user&#39;s codespace.  You must authenticate using an access token with the &#x60;codespace&#x60; scope to use this endpoint.  GitHub Apps must have write access to the &#x60;codespaces_lifecycle_admin&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="codespaceName">The name of the codespace.</param>
        /// <returns>Codespace</returns>
        public Codespace CodespacesStartForAuthenticatedUser (string codespaceName)
        {
            
            // verify the required parameter 'codespaceName' is set
            if (codespaceName == null) throw new ApiException(400, "Missing required parameter 'codespaceName' when calling CodespacesStartForAuthenticatedUser");
            

            var path = "/user/codespaces/{codespace_name}/start";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "codespace_name" + "}", ApiClient.ParameterToString(codespaceName));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CodespacesStartForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CodespacesStartForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return (Codespace) ApiClient.Deserialize(response.Content, typeof(Codespace), response.Headers);
        }

        /// <summary>
        /// Stop a codespace for the authenticated user Stops a user&#39;s codespace.  You must authenticate using an access token with the &#x60;codespace&#x60; scope to use this endpoint.  GitHub Apps must have write access to the &#x60;codespaces_lifecycle_admin&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="codespaceName">The name of the codespace.</param>
        /// <returns>Codespace</returns>
        public Codespace CodespacesStopForAuthenticatedUser (string codespaceName)
        {
            
            // verify the required parameter 'codespaceName' is set
            if (codespaceName == null) throw new ApiException(400, "Missing required parameter 'codespaceName' when calling CodespacesStopForAuthenticatedUser");
            

            var path = "/user/codespaces/{codespace_name}/stop";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "codespace_name" + "}", ApiClient.ParameterToString(codespaceName));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CodespacesStopForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CodespacesStopForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return (Codespace) ApiClient.Deserialize(response.Content, typeof(Codespace), response.Headers);
        }

        /// <summary>
        /// Stop a codespace for an organization user Stops a user&#39;s codespace.  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <param name="codespaceName">The name of the codespace.</param>
        /// <returns>Codespace</returns>
        public Codespace CodespacesStopInOrganization (string org, string username, string codespaceName)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling CodespacesStopInOrganization");
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling CodespacesStopInOrganization");
            
            // verify the required parameter 'codespaceName' is set
            if (codespaceName == null) throw new ApiException(400, "Missing required parameter 'codespaceName' when calling CodespacesStopInOrganization");
            

            var path = "/orgs/{org}/members/{username}/codespaces/{codespace_name}/stop";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "username" + "}", ApiClient.ParameterToString(username));
path = path.Replace("{" + "codespace_name" + "}", ApiClient.ParameterToString(codespaceName));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CodespacesStopInOrganization: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CodespacesStopInOrganization: " + response.ErrorMessage, response.ErrorMessage);

            return (Codespace) ApiClient.Deserialize(response.Content, typeof(Codespace), response.Headers);
        }

        /// <summary>
        /// Update a codespace for the authenticated user Updates a codespace owned by the authenticated user. Currently only the codespace&#39;s machine type and recent folders can be modified using this endpoint.  If you specify a new machine type it will be applied the next time your codespace is started.  You must authenticate using an access token with the &#x60;codespace&#x60; scope to use this endpoint.  GitHub Apps must have write access to the &#x60;codespaces&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="codespaceName">The name of the codespace.</param>
        /// <param name="codespacesUpdateForAuthenticatedUserRequest"></param>
        /// <returns>Codespace</returns>
        public Codespace CodespacesUpdateForAuthenticatedUser (string codespaceName, CodespacesUpdateForAuthenticatedUserRequest codespacesUpdateForAuthenticatedUserRequest)
        {
            
            // verify the required parameter 'codespaceName' is set
            if (codespaceName == null) throw new ApiException(400, "Missing required parameter 'codespaceName' when calling CodespacesUpdateForAuthenticatedUser");
            

            var path = "/user/codespaces/{codespace_name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "codespace_name" + "}", ApiClient.ParameterToString(codespaceName));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(codespacesUpdateForAuthenticatedUserRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CodespacesUpdateForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CodespacesUpdateForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return (Codespace) ApiClient.Deserialize(response.Content, typeof(Codespace), response.Headers);
        }

    }
}
