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
    public interface IActionsApi
    {
        /// <summary>
        /// Add custom labels to a self-hosted runner for an organization Add custom labels to a self-hosted runner configured in an organization.  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="runnerId">Unique identifier of the self-hosted runner.</param>
        /// <param name="enterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest"></param>
        /// <returns>EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response</returns>
        EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response ActionsAddCustomLabelsToSelfHostedRunnerForOrg (string org, int? runnerId, EnterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest enterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest);
        /// <summary>
        /// Add custom labels to a self-hosted runner for a repository Add custom labels to a self-hosted runner configured in a repository.  You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="runnerId">Unique identifier of the self-hosted runner.</param>
        /// <param name="enterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest"></param>
        /// <returns>EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response</returns>
        EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response ActionsAddCustomLabelsToSelfHostedRunnerForRepo (string owner, string repo, int? runnerId, EnterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest enterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest);
        /// <summary>
        /// Add repository access to a self-hosted runner group in an organization The self-hosted runner groups REST API is available with GitHub Enterprise Cloud. For more information, see \&quot;[GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products).\&quot;   Adds a repository to the list of selected repositories that can access a self-hosted runner group. The runner group must have &#x60;visibility&#x60; set to &#x60;selected&#x60;. For more information, see \&quot;[Create a self-hosted runner group for an organization](#create-a-self-hosted-runner-group-for-an-organization).\&quot;  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="runnerGroupId">Unique identifier of the self-hosted runner group.</param>
        /// <param name="repositoryId">The unique identifier of the repository.</param>
        /// <returns></returns>
        void ActionsAddRepoAccessToSelfHostedRunnerGroupInOrg (string org, int? runnerGroupId, int? repositoryId);
        /// <summary>
        /// Add selected repository to an organization secret Adds a repository to an organization secret when the &#x60;visibility&#x60; for repository access is set to &#x60;selected&#x60;. The visibility is set when you [Create or update an organization secret](https://docs.github.com/rest/reference/actions#create-or-update-an-organization-secret). You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;secrets&#x60; organization permission to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="secretName">The name of the secret.</param>
        /// <param name="repositoryId"></param>
        /// <returns></returns>
        void ActionsAddSelectedRepoToOrgSecret (string org, string secretName, int? repositoryId);
        /// <summary>
        /// Add a self-hosted runner to a group for an organization The self-hosted runner groups REST API is available with GitHub Enterprise Cloud. For more information, see \&quot;[GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products).\&quot;   Adds a self-hosted runner to a runner group configured in an organization.  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="runnerGroupId">Unique identifier of the self-hosted runner group.</param>
        /// <param name="runnerId">Unique identifier of the self-hosted runner.</param>
        /// <returns></returns>
        void ActionsAddSelfHostedRunnerToGroupForOrg (string org, int? runnerGroupId, int? runnerId);
        /// <summary>
        /// Approve a workflow run for a fork pull request Approves a workflow run for a pull request from a public fork of a first time contributor. For more information, see [\&quot;Approving workflow runs from public forks](https://docs.github.com/actions/managing-workflow-runs/approving-workflow-runs-from-public-forks).\&quot;  You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;actions:write&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="runId">The unique identifier of the workflow run.</param>
        /// <returns>Object</returns>
        Object ActionsApproveWorkflowRun (string owner, string repo, int? runId);
        /// <summary>
        /// Cancel a workflow run Cancels a workflow run using its &#x60;id&#x60;. You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;actions:write&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="runId">The unique identifier of the workflow run.</param>
        /// <returns>Object</returns>
        Object ActionsCancelWorkflowRun (string owner, string repo, int? runId);
        /// <summary>
        /// Create or update an environment secret Creates or updates an environment secret with an encrypted value. Encrypt your secret using [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages). You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;secrets&#x60; repository permission to use this endpoint.  #### Example encrypting a secret using Node.js  Encrypt your secret using the [tweetsodium](https://github.com/github/tweetsodium) library.  &#x60;&#x60;&#x60; const sodium &#x3D; require(&#39;tweetsodium&#39;);  const key &#x3D; \&quot;base64-encoded-public-key\&quot;; const value &#x3D; \&quot;plain-text-secret\&quot;;  // Convert the message and key to Uint8Array&#39;s (Buffer implements that interface) const messageBytes &#x3D; Buffer.from(value); const keyBytes &#x3D; Buffer.from(key, &#39;base64&#39;);  // Encrypt using LibSodium. const encryptedBytes &#x3D; sodium.seal(messageBytes, keyBytes);  // Base64 the encrypted secret const encrypted &#x3D; Buffer.from(encryptedBytes).toString(&#39;base64&#39;);  console.log(encrypted); &#x60;&#x60;&#x60;   #### Example encrypting a secret using Python  Encrypt your secret using [pynacl](https://pynacl.readthedocs.io/en/latest/public/#nacl-public-sealedbox) with Python 3.  &#x60;&#x60;&#x60; from base64 import b64encode from nacl import encoding, public  def encrypt(public_key: str, secret_value: str) -&gt; str:   \&quot;\&quot;\&quot;Encrypt a Unicode string using the public key.\&quot;\&quot;\&quot;   public_key &#x3D; public.PublicKey(public_key.encode(\&quot;utf-8\&quot;), encoding.Base64Encoder())   sealed_box &#x3D; public.SealedBox(public_key)   encrypted &#x3D; sealed_box.encrypt(secret_value.encode(\&quot;utf-8\&quot;))   return b64encode(encrypted).decode(\&quot;utf-8\&quot;) &#x60;&#x60;&#x60;  #### Example encrypting a secret using C#  Encrypt your secret using the [Sodium.Core](https://www.nuget.org/packages/Sodium.Core/) package.  &#x60;&#x60;&#x60; var secretValue &#x3D; System.Text.Encoding.UTF8.GetBytes(\&quot;mySecret\&quot;); var publicKey &#x3D; Convert.FromBase64String(\&quot;2Sg8iYjAxxmI2LvUXpJjkYrMxURPc8r+dB7TJyvvcCU&#x3D;\&quot;);  var sealedPublicKeyBox &#x3D; Sodium.SealedPublicKeyBox.Create(secretValue, publicKey);  Console.WriteLine(Convert.ToBase64String(sealedPublicKeyBox)); &#x60;&#x60;&#x60;  #### Example encrypting a secret using Ruby  Encrypt your secret using the [rbnacl](https://github.com/RubyCrypto/rbnacl) gem.  &#x60;&#x60;&#x60;ruby require \&quot;rbnacl\&quot; require \&quot;base64\&quot;  key &#x3D; Base64.decode64(\&quot;+ZYvJDZMHUfBkJdyq5Zm9SKqeuBQ4sj+6sfjlH4CgG0&#x3D;\&quot;) public_key &#x3D; RbNaCl::PublicKey.new(key)  box &#x3D; RbNaCl::Boxes::Sealed.from_public_key(public_key) encrypted_secret &#x3D; box.encrypt(\&quot;my_secret\&quot;)  # Print the base64 encoded secret puts Base64.strict_encode64(encrypted_secret) &#x60;&#x60;&#x60;
        /// </summary>
        /// <param name="repositoryId">The unique identifier of the repository.</param>
        /// <param name="environmentName">The name of the environment</param>
        /// <param name="secretName">The name of the secret.</param>
        /// <param name="actionsCreateOrUpdateEnvironmentSecretRequest"></param>
        /// <returns>Object</returns>
        Object ActionsCreateOrUpdateEnvironmentSecret (int? repositoryId, string environmentName, string secretName, ActionsCreateOrUpdateEnvironmentSecretRequest actionsCreateOrUpdateEnvironmentSecretRequest);
        /// <summary>
        /// Create or update an organization secret Creates or updates an organization secret with an encrypted value. Encrypt your secret using [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages). You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;secrets&#x60; organization permission to use this endpoint.  #### Example encrypting a secret using Node.js  Encrypt your secret using the [tweetsodium](https://github.com/github/tweetsodium) library.  &#x60;&#x60;&#x60; const sodium &#x3D; require(&#39;tweetsodium&#39;);  const key &#x3D; \&quot;base64-encoded-public-key\&quot;; const value &#x3D; \&quot;plain-text-secret\&quot;;  // Convert the message and key to Uint8Array&#39;s (Buffer implements that interface) const messageBytes &#x3D; Buffer.from(value); const keyBytes &#x3D; Buffer.from(key, &#39;base64&#39;);  // Encrypt using LibSodium. const encryptedBytes &#x3D; sodium.seal(messageBytes, keyBytes);  // Base64 the encrypted secret const encrypted &#x3D; Buffer.from(encryptedBytes).toString(&#39;base64&#39;);  console.log(encrypted); &#x60;&#x60;&#x60;   #### Example encrypting a secret using Python  Encrypt your secret using [pynacl](https://pynacl.readthedocs.io/en/latest/public/#nacl-public-sealedbox) with Python 3.  &#x60;&#x60;&#x60; from base64 import b64encode from nacl import encoding, public  def encrypt(public_key: str, secret_value: str) -&gt; str:   \&quot;\&quot;\&quot;Encrypt a Unicode string using the public key.\&quot;\&quot;\&quot;   public_key &#x3D; public.PublicKey(public_key.encode(\&quot;utf-8\&quot;), encoding.Base64Encoder())   sealed_box &#x3D; public.SealedBox(public_key)   encrypted &#x3D; sealed_box.encrypt(secret_value.encode(\&quot;utf-8\&quot;))   return b64encode(encrypted).decode(\&quot;utf-8\&quot;) &#x60;&#x60;&#x60;  #### Example encrypting a secret using C#  Encrypt your secret using the [Sodium.Core](https://www.nuget.org/packages/Sodium.Core/) package.  &#x60;&#x60;&#x60; var secretValue &#x3D; System.Text.Encoding.UTF8.GetBytes(\&quot;mySecret\&quot;); var publicKey &#x3D; Convert.FromBase64String(\&quot;2Sg8iYjAxxmI2LvUXpJjkYrMxURPc8r+dB7TJyvvcCU&#x3D;\&quot;);  var sealedPublicKeyBox &#x3D; Sodium.SealedPublicKeyBox.Create(secretValue, publicKey);  Console.WriteLine(Convert.ToBase64String(sealedPublicKeyBox)); &#x60;&#x60;&#x60;  #### Example encrypting a secret using Ruby  Encrypt your secret using the [rbnacl](https://github.com/RubyCrypto/rbnacl) gem.  &#x60;&#x60;&#x60;ruby require \&quot;rbnacl\&quot; require \&quot;base64\&quot;  key &#x3D; Base64.decode64(\&quot;+ZYvJDZMHUfBkJdyq5Zm9SKqeuBQ4sj+6sfjlH4CgG0&#x3D;\&quot;) public_key &#x3D; RbNaCl::PublicKey.new(key)  box &#x3D; RbNaCl::Boxes::Sealed.from_public_key(public_key) encrypted_secret &#x3D; box.encrypt(\&quot;my_secret\&quot;)  # Print the base64 encoded secret puts Base64.strict_encode64(encrypted_secret) &#x60;&#x60;&#x60;
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="secretName">The name of the secret.</param>
        /// <param name="actionsCreateOrUpdateOrgSecretRequest"></param>
        /// <returns>Object</returns>
        Object ActionsCreateOrUpdateOrgSecret (string org, string secretName, ActionsCreateOrUpdateOrgSecretRequest actionsCreateOrUpdateOrgSecretRequest);
        /// <summary>
        /// Create or update a repository secret Creates or updates a repository secret with an encrypted value. Encrypt your secret using [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages). You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;secrets&#x60; repository permission to use this endpoint.  #### Example encrypting a secret using Node.js  Encrypt your secret using the [tweetsodium](https://github.com/github/tweetsodium) library.  &#x60;&#x60;&#x60; const sodium &#x3D; require(&#39;tweetsodium&#39;);  const key &#x3D; \&quot;base64-encoded-public-key\&quot;; const value &#x3D; \&quot;plain-text-secret\&quot;;  // Convert the message and key to Uint8Array&#39;s (Buffer implements that interface) const messageBytes &#x3D; Buffer.from(value); const keyBytes &#x3D; Buffer.from(key, &#39;base64&#39;);  // Encrypt using LibSodium. const encryptedBytes &#x3D; sodium.seal(messageBytes, keyBytes);  // Base64 the encrypted secret const encrypted &#x3D; Buffer.from(encryptedBytes).toString(&#39;base64&#39;);  console.log(encrypted); &#x60;&#x60;&#x60;   #### Example encrypting a secret using Python  Encrypt your secret using [pynacl](https://pynacl.readthedocs.io/en/latest/public/#nacl-public-sealedbox) with Python 3.  &#x60;&#x60;&#x60; from base64 import b64encode from nacl import encoding, public  def encrypt(public_key: str, secret_value: str) -&gt; str:   \&quot;\&quot;\&quot;Encrypt a Unicode string using the public key.\&quot;\&quot;\&quot;   public_key &#x3D; public.PublicKey(public_key.encode(\&quot;utf-8\&quot;), encoding.Base64Encoder())   sealed_box &#x3D; public.SealedBox(public_key)   encrypted &#x3D; sealed_box.encrypt(secret_value.encode(\&quot;utf-8\&quot;))   return b64encode(encrypted).decode(\&quot;utf-8\&quot;) &#x60;&#x60;&#x60;  #### Example encrypting a secret using C#  Encrypt your secret using the [Sodium.Core](https://www.nuget.org/packages/Sodium.Core/) package.  &#x60;&#x60;&#x60; var secretValue &#x3D; System.Text.Encoding.UTF8.GetBytes(\&quot;mySecret\&quot;); var publicKey &#x3D; Convert.FromBase64String(\&quot;2Sg8iYjAxxmI2LvUXpJjkYrMxURPc8r+dB7TJyvvcCU&#x3D;\&quot;);  var sealedPublicKeyBox &#x3D; Sodium.SealedPublicKeyBox.Create(secretValue, publicKey);  Console.WriteLine(Convert.ToBase64String(sealedPublicKeyBox)); &#x60;&#x60;&#x60;  #### Example encrypting a secret using Ruby  Encrypt your secret using the [rbnacl](https://github.com/RubyCrypto/rbnacl) gem.  &#x60;&#x60;&#x60;ruby require \&quot;rbnacl\&quot; require \&quot;base64\&quot;  key &#x3D; Base64.decode64(\&quot;+ZYvJDZMHUfBkJdyq5Zm9SKqeuBQ4sj+6sfjlH4CgG0&#x3D;\&quot;) public_key &#x3D; RbNaCl::PublicKey.new(key)  box &#x3D; RbNaCl::Boxes::Sealed.from_public_key(public_key) encrypted_secret &#x3D; box.encrypt(\&quot;my_secret\&quot;)  # Print the base64 encoded secret puts Base64.strict_encode64(encrypted_secret) &#x60;&#x60;&#x60;
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="secretName">The name of the secret.</param>
        /// <param name="actionsCreateOrUpdateRepoSecretRequest"></param>
        /// <returns>Object</returns>
        Object ActionsCreateOrUpdateRepoSecret (string owner, string repo, string secretName, ActionsCreateOrUpdateRepoSecretRequest actionsCreateOrUpdateRepoSecretRequest);
        /// <summary>
        /// Create a registration token for an organization Returns a token that you can pass to the &#x60;config&#x60; script. The token expires after one hour.  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint.  #### Example using registration token  Configure your self-hosted runner, replacing &#x60;TOKEN&#x60; with the registration token provided by this endpoint.  &#x60;&#x60;&#x60; ./config.sh - -url https://github.com/octo-org - -token TOKEN &#x60;&#x60;&#x60;
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <returns>AuthenticationToken</returns>
        AuthenticationToken ActionsCreateRegistrationTokenForOrg (string org);
        /// <summary>
        /// Create a registration token for a repository Returns a token that you can pass to the &#x60;config&#x60; script. The token expires after one hour. You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint.  #### Example using registration token   Configure your self-hosted runner, replacing &#x60;TOKEN&#x60; with the registration token provided by this endpoint.  &#x60;&#x60;&#x60; ./config.sh - -url https://github.com/octo-org/octo-repo-artifacts - -token TOKEN &#x60;&#x60;&#x60;
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>AuthenticationToken</returns>
        AuthenticationToken ActionsCreateRegistrationTokenForRepo (string owner, string repo);
        /// <summary>
        /// Create a remove token for an organization Returns a token that you can pass to the &#x60;config&#x60; script to remove a self-hosted runner from an organization. The token expires after one hour.  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint.  #### Example using remove token  To remove your self-hosted runner from an organization, replace &#x60;TOKEN&#x60; with the remove token provided by this endpoint.  &#x60;&#x60;&#x60; ./config.sh remove - -token TOKEN &#x60;&#x60;&#x60;
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <returns>AuthenticationToken</returns>
        AuthenticationToken ActionsCreateRemoveTokenForOrg (string org);
        /// <summary>
        /// Create a remove token for a repository Returns a token that you can pass to remove a self-hosted runner from a repository. The token expires after one hour. You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint.  #### Example using remove token   To remove your self-hosted runner from a repository, replace TOKEN with the remove token provided by this endpoint.  &#x60;&#x60;&#x60; ./config.sh remove - -token TOKEN &#x60;&#x60;&#x60;
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>AuthenticationToken</returns>
        AuthenticationToken ActionsCreateRemoveTokenForRepo (string owner, string repo);
        /// <summary>
        /// Create a self-hosted runner group for an organization The self-hosted runner groups REST API is available with GitHub Enterprise Cloud and GitHub Enterprise Server. For more information, see \&quot;[GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products).\&quot;  Creates a new self-hosted runner group for an organization.  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="actionsCreateSelfHostedRunnerGroupForOrgRequest"></param>
        /// <returns>ActionsListSelfHostedRunnerGroupsForOrg200ResponseRunnerGroupsInner</returns>
        ActionsListSelfHostedRunnerGroupsForOrg200ResponseRunnerGroupsInner ActionsCreateSelfHostedRunnerGroupForOrg (string org, ActionsCreateSelfHostedRunnerGroupForOrgRequest actionsCreateSelfHostedRunnerGroupForOrgRequest);
        /// <summary>
        /// Create a workflow dispatch event You can use this endpoint to manually trigger a GitHub Actions workflow run. You can replace &#x60;workflow_id&#x60; with the workflow file name. For example, you could use &#x60;main.yaml&#x60;.  You must configure your GitHub Actions workflow to run when the [&#x60;workflow_dispatch&#x60; webhook](/developers/webhooks-and-events/webhook-events-and-payloads#workflow_dispatch) event occurs. The &#x60;inputs&#x60; are configured in the workflow file. For more information about how to configure the &#x60;workflow_dispatch&#x60; event in the workflow file, see \&quot;[Events that trigger workflows](/actions/reference/events-that-trigger-workflows#workflow_dispatch).\&quot;  You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;actions:write&#x60; permission to use this endpoint. For more information, see \&quot;[Creating a personal access token for the command line](https://docs.github.com/articles/creating-a-personal-access-token-for-the-command-line).\&quot;
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="workflowId">The ID of the workflow. You can also pass the workflow file name as a string.</param>
        /// <param name="actionsCreateWorkflowDispatchRequest"></param>
        /// <returns></returns>
        void ActionsCreateWorkflowDispatch (string owner, string repo, ActionsGetWorkflowWorkflowIdParameter workflowId, ActionsCreateWorkflowDispatchRequest actionsCreateWorkflowDispatchRequest);
        /// <summary>
        /// Delete a GitHub Actions cache for a repository (using a cache ID) Deletes a GitHub Actions cache for a repository, using a cache ID.  You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint.  GitHub Apps must have the &#x60;actions:write&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="cacheId">The unique identifier of the GitHub Actions cache.</param>
        /// <returns></returns>
        void ActionsDeleteActionsCacheById (string owner, string repo, int? cacheId);
        /// <summary>
        /// Delete GitHub Actions caches for a repository (using a cache key) Deletes one or more GitHub Actions caches for a repository, using a complete cache key. By default, all caches that match the provided key are deleted, but you can optionally provide a Git ref to restrict deletions to caches that match both the provided key and the Git ref.  You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint.  GitHub Apps must have the &#x60;actions:write&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="key">A key for identifying the cache.</param>
        /// <param name="_ref">The Git reference for the results you want to list. The &#x60;ref&#x60; for a branch can be formatted either as &#x60;refs/heads/&lt;branch name&gt;&#x60; or simply &#x60;&lt;branch name&gt;&#x60;. To reference a pull request use &#x60;refs/pull/&lt;number&gt;/merge&#x60;.</param>
        /// <returns>RepositoryActionsCaches</returns>
        RepositoryActionsCaches ActionsDeleteActionsCacheByKey (string owner, string repo, string key, string _ref);
        /// <summary>
        /// Delete an artifact Deletes an artifact for a workflow run. You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;actions:write&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="artifactId">The unique identifier of the artifact.</param>
        /// <returns></returns>
        void ActionsDeleteArtifact (string owner, string repo, int? artifactId);
        /// <summary>
        /// Delete an environment secret Deletes a secret in an environment using the secret name. You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;secrets&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="repositoryId">The unique identifier of the repository.</param>
        /// <param name="environmentName">The name of the environment</param>
        /// <param name="secretName">The name of the secret.</param>
        /// <returns></returns>
        void ActionsDeleteEnvironmentSecret (int? repositoryId, string environmentName, string secretName);
        /// <summary>
        /// Delete an organization secret Deletes a secret in an organization using the secret name. You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;secrets&#x60; organization permission to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="secretName">The name of the secret.</param>
        /// <returns></returns>
        void ActionsDeleteOrgSecret (string org, string secretName);
        /// <summary>
        /// Delete a repository secret Deletes a secret in a repository using the secret name. You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;secrets&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="secretName">The name of the secret.</param>
        /// <returns></returns>
        void ActionsDeleteRepoSecret (string owner, string repo, string secretName);
        /// <summary>
        /// Delete a self-hosted runner from an organization Forces the removal of a self-hosted runner from an organization. You can use this endpoint to completely remove the runner when the machine you were using no longer exists.  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="runnerId">Unique identifier of the self-hosted runner.</param>
        /// <returns></returns>
        void ActionsDeleteSelfHostedRunnerFromOrg (string org, int? runnerId);
        /// <summary>
        /// Delete a self-hosted runner from a repository Forces the removal of a self-hosted runner from a repository. You can use this endpoint to completely remove the runner when the machine you were using no longer exists.  You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="runnerId">Unique identifier of the self-hosted runner.</param>
        /// <returns></returns>
        void ActionsDeleteSelfHostedRunnerFromRepo (string owner, string repo, int? runnerId);
        /// <summary>
        /// Delete a self-hosted runner group from an organization The self-hosted runner groups REST API is available with GitHub Enterprise Cloud. For more information, see \&quot;[GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products).\&quot;  Deletes a self-hosted runner group for an organization.  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="runnerGroupId">Unique identifier of the self-hosted runner group.</param>
        /// <returns></returns>
        void ActionsDeleteSelfHostedRunnerGroupFromOrg (string org, int? runnerGroupId);
        /// <summary>
        /// Delete a workflow run Delete a specific workflow run. Anyone with write access to the repository can use this endpoint. If the repository is private you must use an access token with the &#x60;repo&#x60; scope. GitHub Apps must have the &#x60;actions:write&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="runId">The unique identifier of the workflow run.</param>
        /// <returns></returns>
        void ActionsDeleteWorkflowRun (string owner, string repo, int? runId);
        /// <summary>
        /// Delete workflow run logs Deletes all logs for a workflow run. You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;actions:write&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="runId">The unique identifier of the workflow run.</param>
        /// <returns></returns>
        void ActionsDeleteWorkflowRunLogs (string owner, string repo, int? runId);
        /// <summary>
        /// Disable a selected repository for GitHub Actions in an organization Removes a repository from the list of selected repositories that are enabled for GitHub Actions in an organization. To use this endpoint, the organization permission policy for &#x60;enabled_repositories&#x60; must be configured to &#x60;selected&#x60;. For more information, see \&quot;[Set GitHub Actions permissions for an organization](#set-github-actions-permissions-for-an-organization).\&quot;  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;administration&#x60; organization permission to use this API.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="repositoryId">The unique identifier of the repository.</param>
        /// <returns></returns>
        void ActionsDisableSelectedRepositoryGithubActionsOrganization (string org, int? repositoryId);
        /// <summary>
        /// Disable a workflow Disables a workflow and sets the &#x60;state&#x60; of the workflow to &#x60;disabled_manually&#x60;. You can replace &#x60;workflow_id&#x60; with the workflow file name. For example, you could use &#x60;main.yaml&#x60;.  You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;actions:write&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="workflowId">The ID of the workflow. You can also pass the workflow file name as a string.</param>
        /// <returns></returns>
        void ActionsDisableWorkflow (string owner, string repo, ActionsGetWorkflowWorkflowIdParameter workflowId);
        /// <summary>
        /// Download an artifact Gets a redirect URL to download an archive for a repository. This URL expires after 1 minute. Look for &#x60;Location:&#x60; in the response header to find the URL for the download. The &#x60;:archive_format&#x60; must be &#x60;zip&#x60;. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the &#x60;repo&#x60; scope. GitHub Apps must have the &#x60;actions:read&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="artifactId">The unique identifier of the artifact.</param>
        /// <param name="archiveFormat"></param>
        /// <returns></returns>
        void ActionsDownloadArtifact (string owner, string repo, int? artifactId, string archiveFormat);
        /// <summary>
        /// Download job logs for a workflow run Gets a redirect URL to download a plain text file of logs for a workflow job. This link expires after 1 minute. Look for &#x60;Location:&#x60; in the response header to find the URL for the download. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the &#x60;repo&#x60; scope. GitHub Apps must have the &#x60;actions:read&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="jobId">The unique identifier of the job.</param>
        /// <returns></returns>
        void ActionsDownloadJobLogsForWorkflowRun (string owner, string repo, int? jobId);
        /// <summary>
        /// Download workflow run attempt logs Gets a redirect URL to download an archive of log files for a specific workflow run attempt. This link expires after 1 minute. Look for &#x60;Location:&#x60; in the response header to find the URL for the download. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the &#x60;repo&#x60; scope. GitHub Apps must have the &#x60;actions:read&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="runId">The unique identifier of the workflow run.</param>
        /// <param name="attemptNumber">The attempt number of the workflow run.</param>
        /// <returns></returns>
        void ActionsDownloadWorkflowRunAttemptLogs (string owner, string repo, int? runId, int? attemptNumber);
        /// <summary>
        /// Download workflow run logs Gets a redirect URL to download an archive of log files for a workflow run. This link expires after 1 minute. Look for &#x60;Location:&#x60; in the response header to find the URL for the download. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the &#x60;repo&#x60; scope. GitHub Apps must have the &#x60;actions:read&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="runId">The unique identifier of the workflow run.</param>
        /// <returns></returns>
        void ActionsDownloadWorkflowRunLogs (string owner, string repo, int? runId);
        /// <summary>
        /// Enable a selected repository for GitHub Actions in an organization Adds a repository to the list of selected repositories that are enabled for GitHub Actions in an organization. To use this endpoint, the organization permission policy for &#x60;enabled_repositories&#x60; must be must be configured to &#x60;selected&#x60;. For more information, see \&quot;[Set GitHub Actions permissions for an organization](#set-github-actions-permissions-for-an-organization).\&quot;  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;administration&#x60; organization permission to use this API.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="repositoryId">The unique identifier of the repository.</param>
        /// <returns></returns>
        void ActionsEnableSelectedRepositoryGithubActionsOrganization (string org, int? repositoryId);
        /// <summary>
        /// Enable a workflow Enables a workflow and sets the &#x60;state&#x60; of the workflow to &#x60;active&#x60;. You can replace &#x60;workflow_id&#x60; with the workflow file name. For example, you could use &#x60;main.yaml&#x60;.  You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;actions:write&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="workflowId">The ID of the workflow. You can also pass the workflow file name as a string.</param>
        /// <returns></returns>
        void ActionsEnableWorkflow (string owner, string repo, ActionsGetWorkflowWorkflowIdParameter workflowId);
        /// <summary>
        /// List GitHub Actions caches for a repository Lists the GitHub Actions caches for a repository. You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;actions:read&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <param name="_ref">The Git reference for the results you want to list. The &#x60;ref&#x60; for a branch can be formatted either as &#x60;refs/heads/&lt;branch name&gt;&#x60; or simply &#x60;&lt;branch name&gt;&#x60;. To reference a pull request use &#x60;refs/pull/&lt;number&gt;/merge&#x60;.</param>
        /// <param name="key">An explicit key or prefix for identifying the cache</param>
        /// <param name="sort">The property to sort the results by. &#x60;created_at&#x60; means when the cache was created. &#x60;last_accessed_at&#x60; means when the cache was last accessed. &#x60;size_in_bytes&#x60; is the size of the cache in bytes.</param>
        /// <param name="direction">The direction to sort the results by.</param>
        /// <returns>RepositoryActionsCaches</returns>
        RepositoryActionsCaches ActionsGetActionsCacheList (string owner, string repo, int? perPage, int? page, string _ref, string key, string sort, string direction);
        /// <summary>
        /// Get GitHub Actions cache usage for a repository Gets GitHub Actions cache usage for a repository. The data fetched using this API is refreshed approximately every 5 minutes, so values returned from this endpoint may take at least 5 minutes to get updated. Anyone with read access to the repository can use this endpoint. If the repository is private, you must use an access token with the &#x60;repo&#x60; scope. GitHub Apps must have the &#x60;actions:read&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>ActionsCacheUsageByRepository</returns>
        ActionsCacheUsageByRepository ActionsGetActionsCacheUsage (string owner, string repo);
        /// <summary>
        /// List repositories with GitHub Actions cache usage for an organization Lists repositories and their GitHub Actions cache usage for an organization. The data fetched using this API is refreshed approximately every 5 minutes, so values returned from this endpoint may take at least 5 minutes to get updated. You must authenticate using an access token with the &#x60;read:org&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;organization_admistration:read&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>ActionsGetActionsCacheUsageByRepoForOrg200Response</returns>
        ActionsGetActionsCacheUsageByRepoForOrg200Response ActionsGetActionsCacheUsageByRepoForOrg (string org, int? perPage, int? page);
        /// <summary>
        /// Get GitHub Actions cache usage for an enterprise Gets the total GitHub Actions cache usage for an enterprise. The data fetched using this API is refreshed approximately every 5 minutes, so values returned from this endpoint may take at least 5 minutes to get updated. You must authenticate using an access token with the &#x60;admin:enterprise&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <returns>ActionsGetActionsCacheUsageForEnterprise200Response</returns>
        ActionsGetActionsCacheUsageForEnterprise200Response ActionsGetActionsCacheUsageForEnterprise (string enterprise);
        /// <summary>
        /// Get GitHub Actions cache usage for an organization Gets the total GitHub Actions cache usage for an organization. The data fetched using this API is refreshed approximately every 5 minutes, so values returned from this endpoint may take at least 5 minutes to get updated. You must authenticate using an access token with the &#x60;read:org&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;organization_admistration:read&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <returns>ActionsGetActionsCacheUsageForEnterprise200Response</returns>
        ActionsGetActionsCacheUsageForEnterprise200Response ActionsGetActionsCacheUsageForOrg (string org);
        /// <summary>
        /// Get allowed actions and reusable workflows for an organization Gets the selected actions and reusable workflows that are allowed in an organization. To use this endpoint, the organization permission policy for &#x60;allowed_actions&#x60; must be configured to &#x60;selected&#x60;. For more information, see \&quot;[Set GitHub Actions permissions for an organization](#set-github-actions-permissions-for-an-organization).\&quot;\&quot;  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;administration&#x60; organization permission to use this API.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <returns>EnterpriseAdminGetAllowedActionsEnterprise200Response</returns>
        EnterpriseAdminGetAllowedActionsEnterprise200Response ActionsGetAllowedActionsOrganization (string org);
        /// <summary>
        /// Get allowed actions and reusable workflows for a repository Gets the settings for selected actions and reusable workflows that are allowed in a repository. To use this endpoint, the repository policy for &#x60;allowed_actions&#x60; must be configured to &#x60;selected&#x60;. For more information, see \&quot;[Set GitHub Actions permissions for a repository](#set-github-actions-permissions-for-a-repository).\&quot;  You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;administration&#x60; repository permission to use this API.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>EnterpriseAdminGetAllowedActionsEnterprise200Response</returns>
        EnterpriseAdminGetAllowedActionsEnterprise200Response ActionsGetAllowedActionsRepository (string owner, string repo);
        /// <summary>
        /// Get an artifact Gets a specific artifact for a workflow run. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the &#x60;repo&#x60; scope. GitHub Apps must have the &#x60;actions:read&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="artifactId">The unique identifier of the artifact.</param>
        /// <returns>Artifact</returns>
        Artifact ActionsGetArtifact (string owner, string repo, int? artifactId);
        /// <summary>
        /// Get the opt-out flag of an OIDC subject claim customization for a repository Gets the &#x60;opt-out&#x60; flag of a GitHub Actions OpenID Connect (OIDC) subject claim customization for a repository. You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;organization_administration:read&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>TheJsonPayloadEnablesDisablesTheUseOfSubClaimCustomization</returns>
        TheJsonPayloadEnablesDisablesTheUseOfSubClaimCustomization ActionsGetCustomOidcSubClaimForRepo (string owner, string repo);
        /// <summary>
        /// Get an environment public key Get the public key for an environment, which you need to encrypt environment secrets. You need to encrypt a secret before you can create or update secrets. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the &#x60;repo&#x60; scope. GitHub Apps must have the &#x60;secrets&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="repositoryId">The unique identifier of the repository.</param>
        /// <param name="environmentName">The name of the environment</param>
        /// <returns>ActionsPublicKey</returns>
        ActionsPublicKey ActionsGetEnvironmentPublicKey (int? repositoryId, string environmentName);
        /// <summary>
        /// Get an environment secret Gets a single environment secret without revealing its encrypted value. You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;secrets&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="repositoryId">The unique identifier of the repository.</param>
        /// <param name="environmentName">The name of the environment</param>
        /// <param name="secretName">The name of the secret.</param>
        /// <returns>ActionsSecret</returns>
        ActionsSecret ActionsGetEnvironmentSecret (int? repositoryId, string environmentName, string secretName);
        /// <summary>
        /// Get default workflow permissions for an enterprise Gets the default workflow permissions granted to the &#x60;GITHUB_TOKEN&#x60; when running workflows in an enterprise, as well as whether GitHub Actions can submit approving pull request reviews. For more information, see \&quot;[Enforcing a policy for workflow permissions in your enterprise](https://docs.github.com/enterprise-cloud@latest/admin/policies/enforcing-policies-for-your-enterprise/enforcing-policies-for-github-actions-in-your-enterprise#enforcing-a-policy-for-workflow-permissions-in-your-enterprise).\&quot;  You must authenticate using an access token with the &#x60;admin:enterprise&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;enterprise_administration:write&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <returns>ActionsGetGithubActionsDefaultWorkflowPermissionsEnterprise200Response</returns>
        ActionsGetGithubActionsDefaultWorkflowPermissionsEnterprise200Response ActionsGetGithubActionsDefaultWorkflowPermissionsEnterprise (string enterprise);
        /// <summary>
        /// Get default workflow permissions for an organization Gets the default workflow permissions granted to the &#x60;GITHUB_TOKEN&#x60; when running workflows in an organization, as well as whether GitHub Actions can submit approving pull request reviews. For more information, see \&quot;[Setting the permissions of the GITHUB_TOKEN for your organization](https://docs.github.com/organizations/managing-organization-settings/disabling-or-limiting-github-actions-for-your-organization#setting-the-permissions-of-the-github_token-for-your-organization).\&quot;  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;administration&#x60; organization permission to use this API.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <returns>ActionsGetGithubActionsDefaultWorkflowPermissionsEnterprise200Response</returns>
        ActionsGetGithubActionsDefaultWorkflowPermissionsEnterprise200Response ActionsGetGithubActionsDefaultWorkflowPermissionsOrganization (string org);
        /// <summary>
        /// Get default workflow permissions for a repository Gets the default workflow permissions granted to the &#x60;GITHUB_TOKEN&#x60; when running workflows in a repository, as well as if GitHub Actions can submit approving pull request reviews. For more information, see \&quot;[Setting the permissions of the GITHUB_TOKEN for your repository](https://docs.github.com/repositories/managing-your-repositorys-settings-and-features/enabling-features-for-your-repository/managing-github-actions-settings-for-a-repository#setting-the-permissions-of-the-github_token-for-your-repository).\&quot;  You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the repository &#x60;administration&#x60; permission to use this API.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>ActionsGetGithubActionsDefaultWorkflowPermissionsEnterprise200Response</returns>
        ActionsGetGithubActionsDefaultWorkflowPermissionsEnterprise200Response ActionsGetGithubActionsDefaultWorkflowPermissionsRepository (string owner, string repo);
        /// <summary>
        /// Get GitHub Actions permissions for an organization Gets the GitHub Actions permissions policy for repositories and allowed actions and reusable workflows in an organization.  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;administration&#x60; organization permission to use this API.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <returns>ActionsGetGithubActionsPermissionsOrganization200Response</returns>
        ActionsGetGithubActionsPermissionsOrganization200Response ActionsGetGithubActionsPermissionsOrganization (string org);
        /// <summary>
        /// Get GitHub Actions permissions for a repository Gets the GitHub Actions permissions policy for a repository, including whether GitHub Actions is enabled and the actions and reusable workflows allowed to run in the repository.  You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;administration&#x60; repository permission to use this API.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>ActionsGetGithubActionsPermissionsRepository200Response</returns>
        ActionsGetGithubActionsPermissionsRepository200Response ActionsGetGithubActionsPermissionsRepository (string owner, string repo);
        /// <summary>
        /// Get a job for a workflow run Gets a specific job in a workflow run. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the &#x60;repo&#x60; scope. GitHub Apps must have the &#x60;actions:read&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="jobId">The unique identifier of the job.</param>
        /// <returns>Job</returns>
        Job ActionsGetJobForWorkflowRun (string owner, string repo, int? jobId);
        /// <summary>
        /// Get an organization public key Gets your public key, which you need to encrypt secrets. You need to encrypt a secret before you can create or update secrets. You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;secrets&#x60; organization permission to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <returns>ActionsPublicKey</returns>
        ActionsPublicKey ActionsGetOrgPublicKey (string org);
        /// <summary>
        /// Get an organization secret Gets a single organization secret without revealing its encrypted value. You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;secrets&#x60; organization permission to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="secretName">The name of the secret.</param>
        /// <returns>ActionsSecretForAnOrganization</returns>
        ActionsSecretForAnOrganization ActionsGetOrgSecret (string org, string secretName);
        /// <summary>
        /// Get pending deployments for a workflow run Get all deployment environments for a workflow run that are waiting for protection rules to pass.  Anyone with read access to the repository can use this endpoint. If the repository is private, you must use an access token with the &#x60;repo&#x60; scope. GitHub Apps must have the &#x60;actions:read&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="runId">The unique identifier of the workflow run.</param>
        /// <returns>List&lt;PendingDeployment&gt;</returns>
        List<PendingDeployment> ActionsGetPendingDeploymentsForRun (string owner, string repo, int? runId);
        /// <summary>
        /// Get a repository public key Gets your public key, which you need to encrypt secrets. You need to encrypt a secret before you can create or update secrets. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the &#x60;repo&#x60; scope. GitHub Apps must have the &#x60;secrets&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>ActionsPublicKey</returns>
        ActionsPublicKey ActionsGetRepoPublicKey (string owner, string repo);
        /// <summary>
        /// Get a repository secret Gets a single repository secret without revealing its encrypted value. You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;secrets&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="secretName">The name of the secret.</param>
        /// <returns>ActionsSecret</returns>
        ActionsSecret ActionsGetRepoSecret (string owner, string repo, string secretName);
        /// <summary>
        /// Get the review history for a workflow run Anyone with read access to the repository can use this endpoint. If the repository is private, you must use an access token with the &#x60;repo&#x60; scope. GitHub Apps must have the &#x60;actions:read&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="runId">The unique identifier of the workflow run.</param>
        /// <returns>List&lt;EnvironmentApproval&gt;</returns>
        List<EnvironmentApproval> ActionsGetReviewsForRun (string owner, string repo, int? runId);
        /// <summary>
        /// Get a self-hosted runner for an organization Gets a specific self-hosted runner configured in an organization.  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="runnerId">Unique identifier of the self-hosted runner.</param>
        /// <returns>SelfHostedRunners</returns>
        SelfHostedRunners ActionsGetSelfHostedRunnerForOrg (string org, int? runnerId);
        /// <summary>
        /// Get a self-hosted runner for a repository Gets a specific self-hosted runner configured in a repository.  You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="runnerId">Unique identifier of the self-hosted runner.</param>
        /// <returns>SelfHostedRunners</returns>
        SelfHostedRunners ActionsGetSelfHostedRunnerForRepo (string owner, string repo, int? runnerId);
        /// <summary>
        /// Get a self-hosted runner group for an organization The self-hosted runner groups REST API is available with GitHub Enterprise Cloud. For more information, see \&quot;[GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products).\&quot;  Gets a specific self-hosted runner group for an organization.  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="runnerGroupId">Unique identifier of the self-hosted runner group.</param>
        /// <returns>ActionsListSelfHostedRunnerGroupsForOrg200ResponseRunnerGroupsInner</returns>
        ActionsListSelfHostedRunnerGroupsForOrg200ResponseRunnerGroupsInner ActionsGetSelfHostedRunnerGroupForOrg (string org, int? runnerGroupId);
        /// <summary>
        /// Get a workflow Gets a specific workflow. You can replace &#x60;workflow_id&#x60; with the workflow file name. For example, you could use &#x60;main.yaml&#x60;. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the &#x60;repo&#x60; scope. GitHub Apps must have the &#x60;actions:read&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="workflowId">The ID of the workflow. You can also pass the workflow file name as a string.</param>
        /// <returns>Workflow</returns>
        Workflow ActionsGetWorkflow (string owner, string repo, ActionsGetWorkflowWorkflowIdParameter workflowId);
        /// <summary>
        /// Get the level of access for workflows outside of the repository Gets the level of access that workflows outside of the repository have to actions and reusable workflows in the repository. This endpoint only applies to internal repositories. For more information, see \&quot;[Managing GitHub Actions settings for a repository](https://docs.github.com/repositories/managing-your-repositorys-settings-and-features/enabling-features-for-your-repository/managing-github-actions-settings-for-a-repository#allowing-access-to-components-in-an-internal-repository).\&quot;  You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the repository &#x60;administration&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>ActionsGetWorkflowAccessToRepository200Response</returns>
        ActionsGetWorkflowAccessToRepository200Response ActionsGetWorkflowAccessToRepository (string owner, string repo);
        /// <summary>
        /// Get a workflow run Gets a specific workflow run. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the &#x60;repo&#x60; scope. GitHub Apps must have the &#x60;actions:read&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="runId">The unique identifier of the workflow run.</param>
        /// <param name="excludePullRequests">If &#x60;true&#x60; pull requests are omitted from the response (empty array).</param>
        /// <returns>WorkflowRun</returns>
        WorkflowRun ActionsGetWorkflowRun (string owner, string repo, int? runId, bool? excludePullRequests);
        /// <summary>
        /// Get a workflow run attempt Gets a specific workflow run attempt. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the &#x60;repo&#x60; scope. GitHub Apps must have the &#x60;actions:read&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="runId">The unique identifier of the workflow run.</param>
        /// <param name="attemptNumber">The attempt number of the workflow run.</param>
        /// <param name="excludePullRequests">If &#x60;true&#x60; pull requests are omitted from the response (empty array).</param>
        /// <returns>WorkflowRun</returns>
        WorkflowRun ActionsGetWorkflowRunAttempt (string owner, string repo, int? runId, int? attemptNumber, bool? excludePullRequests);
        /// <summary>
        /// Get workflow run usage Gets the number of billable minutes and total run time for a specific workflow run. Billable minutes only apply to workflows in private repositories that use GitHub-hosted runners. Usage is listed for each GitHub-hosted runner operating system in milliseconds. Any job re-runs are also included in the usage. The usage does not include the multiplier for macOS and Windows runners and is not rounded up to the nearest whole minute. For more information, see \&quot;[Managing billing for GitHub Actions](https://docs.github.com/github/setting-up-and-managing-billing-and-payments-on-github/managing-billing-for-github-actions)\&quot;.  Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the &#x60;repo&#x60; scope. GitHub Apps must have the &#x60;actions:read&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="runId">The unique identifier of the workflow run.</param>
        /// <returns>WorkflowRunUsage</returns>
        WorkflowRunUsage ActionsGetWorkflowRunUsage (string owner, string repo, int? runId);
        /// <summary>
        /// Get workflow usage Gets the number of billable minutes used by a specific workflow during the current billing cycle. Billable minutes only apply to workflows in private repositories that use GitHub-hosted runners. Usage is listed for each GitHub-hosted runner operating system in milliseconds. Any job re-runs are also included in the usage. The usage does not include the multiplier for macOS and Windows runners and is not rounded up to the nearest whole minute. For more information, see \&quot;[Managing billing for GitHub Actions](https://docs.github.com/github/setting-up-and-managing-billing-and-payments-on-github/managing-billing-for-github-actions)\&quot;.  You can replace &#x60;workflow_id&#x60; with the workflow file name. For example, you could use &#x60;main.yaml&#x60;. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the &#x60;repo&#x60; scope. GitHub Apps must have the &#x60;actions:read&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="workflowId">The ID of the workflow. You can also pass the workflow file name as a string.</param>
        /// <returns>WorkflowUsage</returns>
        WorkflowUsage ActionsGetWorkflowUsage (string owner, string repo, ActionsGetWorkflowWorkflowIdParameter workflowId);
        /// <summary>
        /// List artifacts for a repository Lists all artifacts for a repository. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the &#x60;repo&#x60; scope. GitHub Apps must have the &#x60;actions:read&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>ActionsListArtifactsForRepo200Response</returns>
        ActionsListArtifactsForRepo200Response ActionsListArtifactsForRepo (string owner, string repo, int? perPage, int? page);
        /// <summary>
        /// List environment secrets Lists all secrets available in an environment without revealing their encrypted values. You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;secrets&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="repositoryId">The unique identifier of the repository.</param>
        /// <param name="environmentName">The name of the environment</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>ActionsListRepoSecrets200Response</returns>
        ActionsListRepoSecrets200Response ActionsListEnvironmentSecrets (int? repositoryId, string environmentName, int? perPage, int? page);
        /// <summary>
        /// List jobs for a workflow run Lists jobs for a workflow run. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the &#x60;repo&#x60; scope. GitHub Apps must have the &#x60;actions:read&#x60; permission to use this endpoint. You can use parameters to narrow the list of results. For more information about using parameters, see [Parameters](https://docs.github.com/rest/overview/resources-in-the-rest-api#parameters).
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="runId">The unique identifier of the workflow run.</param>
        /// <param name="filter">Filters jobs by their &#x60;completed_at&#x60; timestamp. &#x60;latest&#x60; returns jobs from the most recent execution of the workflow run. &#x60;all&#x60; returns all jobs for a workflow run, including from old executions of the workflow run.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>ActionsListJobsForWorkflowRunAttempt200Response</returns>
        ActionsListJobsForWorkflowRunAttempt200Response ActionsListJobsForWorkflowRun (string owner, string repo, int? runId, string filter, int? perPage, int? page);
        /// <summary>
        /// List jobs for a workflow run attempt Lists jobs for a specific workflow run attempt. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the &#x60;repo&#x60; scope. GitHub Apps must have the &#x60;actions:read&#x60; permission to use this endpoint. You can use parameters to narrow the list of results. For more information about using parameters, see [Parameters](https://docs.github.com/rest/overview/resources-in-the-rest-api#parameters).
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="runId">The unique identifier of the workflow run.</param>
        /// <param name="attemptNumber">The attempt number of the workflow run.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>ActionsListJobsForWorkflowRunAttempt200Response</returns>
        ActionsListJobsForWorkflowRunAttempt200Response ActionsListJobsForWorkflowRunAttempt (string owner, string repo, int? runId, int? attemptNumber, int? perPage, int? page);
        /// <summary>
        /// List labels for a self-hosted runner for an organization Lists all labels for a self-hosted runner configured in an organization.  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="runnerId">Unique identifier of the self-hosted runner.</param>
        /// <returns>EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response</returns>
        EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response ActionsListLabelsForSelfHostedRunnerForOrg (string org, int? runnerId);
        /// <summary>
        /// List labels for a self-hosted runner for a repository Lists all labels for a self-hosted runner configured in a repository.  You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="runnerId">Unique identifier of the self-hosted runner.</param>
        /// <returns>EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response</returns>
        EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response ActionsListLabelsForSelfHostedRunnerForRepo (string owner, string repo, int? runnerId);
        /// <summary>
        /// List organization secrets Lists all secrets available in an organization without revealing their encrypted values. You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;secrets&#x60; organization permission to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>ActionsListOrgSecrets200Response</returns>
        ActionsListOrgSecrets200Response ActionsListOrgSecrets (string org, int? perPage, int? page);
        /// <summary>
        /// List repository access to a self-hosted runner group in an organization The self-hosted runner groups REST API is available with GitHub Enterprise Cloud and GitHub Enterprise Server. For more information, see \&quot;[GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products).\&quot;  Lists the repositories with access to a self-hosted runner group configured in an organization.  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="runnerGroupId">Unique identifier of the self-hosted runner group.</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <returns>ActionsListRepoAccessToSelfHostedRunnerGroupInOrg200Response</returns>
        ActionsListRepoAccessToSelfHostedRunnerGroupInOrg200Response ActionsListRepoAccessToSelfHostedRunnerGroupInOrg (string org, int? runnerGroupId, int? page, int? perPage);
        /// <summary>
        /// List repository secrets Lists all secrets available in a repository without revealing their encrypted values. You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;secrets&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>ActionsListRepoSecrets200Response</returns>
        ActionsListRepoSecrets200Response ActionsListRepoSecrets (string owner, string repo, int? perPage, int? page);
        /// <summary>
        /// List repository workflows Lists the workflows in a repository. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the &#x60;repo&#x60; scope. GitHub Apps must have the &#x60;actions:read&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>ActionsListRepoWorkflows200Response</returns>
        ActionsListRepoWorkflows200Response ActionsListRepoWorkflows (string owner, string repo, int? perPage, int? page);
        /// <summary>
        /// List runner applications for an organization Lists binaries for the runner application that you can download and run.  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <returns>List&lt;RunnerApplication&gt;</returns>
        List<RunnerApplication> ActionsListRunnerApplicationsForOrg (string org);
        /// <summary>
        /// List runner applications for a repository Lists binaries for the runner application that you can download and run.  You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>List&lt;RunnerApplication&gt;</returns>
        List<RunnerApplication> ActionsListRunnerApplicationsForRepo (string owner, string repo);
        /// <summary>
        /// List selected repositories for an organization secret Lists all repositories that have been selected when the &#x60;visibility&#x60; for repository access to a secret is set to &#x60;selected&#x60;. You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;secrets&#x60; organization permission to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="secretName">The name of the secret.</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <returns>ActionsListSelectedReposForOrgSecret200Response</returns>
        ActionsListSelectedReposForOrgSecret200Response ActionsListSelectedReposForOrgSecret (string org, string secretName, int? page, int? perPage);
        /// <summary>
        /// List selected repositories enabled for GitHub Actions in an organization Lists the selected repositories that are enabled for GitHub Actions in an organization. To use this endpoint, the organization permission policy for &#x60;enabled_repositories&#x60; must be configured to &#x60;selected&#x60;. For more information, see \&quot;[Set GitHub Actions permissions for an organization](#set-github-actions-permissions-for-an-organization).\&quot;  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;administration&#x60; organization permission to use this API.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>ActionsListSelectedRepositoriesEnabledGithubActionsOrganization200Response</returns>
        ActionsListSelectedRepositoriesEnabledGithubActionsOrganization200Response ActionsListSelectedRepositoriesEnabledGithubActionsOrganization (string org, int? perPage, int? page);
        /// <summary>
        /// List self-hosted runner groups for an organization The self-hosted runner groups REST API is available with GitHub Enterprise Cloud. For more information, see \&quot;[GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products).\&quot;  Lists all self-hosted runner groups configured in an organization and inherited from an enterprise.  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <param name="visibleToRepository">Only return runner groups that are allowed to be used by this repository.</param>
        /// <returns>ActionsListSelfHostedRunnerGroupsForOrg200Response</returns>
        ActionsListSelfHostedRunnerGroupsForOrg200Response ActionsListSelfHostedRunnerGroupsForOrg (string org, int? perPage, int? page, string visibleToRepository);
        /// <summary>
        /// List self-hosted runners for an organization Lists all self-hosted runners configured in an organization.  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>ActionsListSelfHostedRunnersForOrg200Response</returns>
        ActionsListSelfHostedRunnersForOrg200Response ActionsListSelfHostedRunnersForOrg (string org, int? perPage, int? page);
        /// <summary>
        /// List self-hosted runners for a repository Lists all self-hosted runners configured in a repository. You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>ActionsListSelfHostedRunnersForOrg200Response</returns>
        ActionsListSelfHostedRunnersForOrg200Response ActionsListSelfHostedRunnersForRepo (string owner, string repo, int? perPage, int? page);
        /// <summary>
        /// List self-hosted runners in a group for an organization The self-hosted runner groups REST API is available with GitHub Enterprise Cloud. For more information, see \&quot;[GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products).\&quot;  Lists self-hosted runners that are in a specific organization group.  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="runnerGroupId">Unique identifier of the self-hosted runner group.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>EnterpriseAdminListSelfHostedRunnersInGroupForEnterprise200Response</returns>
        EnterpriseAdminListSelfHostedRunnersInGroupForEnterprise200Response ActionsListSelfHostedRunnersInGroupForOrg (string org, int? runnerGroupId, int? perPage, int? page);
        /// <summary>
        /// List workflow run artifacts Lists artifacts for a workflow run. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the &#x60;repo&#x60; scope. GitHub Apps must have the &#x60;actions:read&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="runId">The unique identifier of the workflow run.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>ActionsListArtifactsForRepo200Response</returns>
        ActionsListArtifactsForRepo200Response ActionsListWorkflowRunArtifacts (string owner, string repo, int? runId, int? perPage, int? page);
        /// <summary>
        /// List workflow runs List all workflow runs for a workflow. You can replace &#x60;workflow_id&#x60; with the workflow file name. For example, you could use &#x60;main.yaml&#x60;. You can use parameters to narrow the list of results. For more information about using parameters, see [Parameters](https://docs.github.com/rest/overview/resources-in-the-rest-api#parameters).  Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the &#x60;repo&#x60; scope.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="workflowId">The ID of the workflow. You can also pass the workflow file name as a string.</param>
        /// <param name="actor">Returns someone&#39;s workflow runs. Use the login for the user who created the &#x60;push&#x60; associated with the check suite or workflow run.</param>
        /// <param name="branch">Returns workflow runs associated with a branch. Use the name of the branch of the &#x60;push&#x60;.</param>
        /// <param name="_event">Returns workflow run triggered by the event you specify. For example, &#x60;push&#x60;, &#x60;pull_request&#x60; or &#x60;issue&#x60;. For more information, see \&quot;[Events that trigger workflows](https://docs.github.com/en/actions/automating-your-workflow-with-github-actions/events-that-trigger-workflows).\&quot;</param>
        /// <param name="status">Returns workflow runs with the check run &#x60;status&#x60; or &#x60;conclusion&#x60; that you specify. For example, a conclusion can be &#x60;success&#x60; or a status can be &#x60;in_progress&#x60;. Only GitHub can set a status of &#x60;waiting&#x60; or &#x60;requested&#x60;.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <param name="created">Returns workflow runs created within the given date-time range. For more information on the syntax, see \&quot;[Understanding the search syntax](https://docs.github.com/search-github/getting-started-with-searching-on-github/understanding-the-search-syntax#query-for-dates).\&quot;</param>
        /// <param name="excludePullRequests">If &#x60;true&#x60; pull requests are omitted from the response (empty array).</param>
        /// <param name="checkSuiteId">Returns workflow runs with the &#x60;check_suite_id&#x60; that you specify.</param>
        /// <returns>ActionsListWorkflowRunsForRepo200Response</returns>
        ActionsListWorkflowRunsForRepo200Response ActionsListWorkflowRuns (string owner, string repo, ActionsGetWorkflowWorkflowIdParameter workflowId, string actor, string branch, string _event, string status, int? perPage, int? page, DateTime? created, bool? excludePullRequests, int? checkSuiteId);
        /// <summary>
        /// List workflow runs for a repository Lists all workflow runs for a repository. You can use parameters to narrow the list of results. For more information about using parameters, see [Parameters](https://docs.github.com/rest/overview/resources-in-the-rest-api#parameters).  Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the &#x60;repo&#x60; scope. GitHub Apps must have the &#x60;actions:read&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="actor">Returns someone&#39;s workflow runs. Use the login for the user who created the &#x60;push&#x60; associated with the check suite or workflow run.</param>
        /// <param name="branch">Returns workflow runs associated with a branch. Use the name of the branch of the &#x60;push&#x60;.</param>
        /// <param name="_event">Returns workflow run triggered by the event you specify. For example, &#x60;push&#x60;, &#x60;pull_request&#x60; or &#x60;issue&#x60;. For more information, see \&quot;[Events that trigger workflows](https://docs.github.com/en/actions/automating-your-workflow-with-github-actions/events-that-trigger-workflows).\&quot;</param>
        /// <param name="status">Returns workflow runs with the check run &#x60;status&#x60; or &#x60;conclusion&#x60; that you specify. For example, a conclusion can be &#x60;success&#x60; or a status can be &#x60;in_progress&#x60;. Only GitHub can set a status of &#x60;waiting&#x60; or &#x60;requested&#x60;.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <param name="created">Returns workflow runs created within the given date-time range. For more information on the syntax, see \&quot;[Understanding the search syntax](https://docs.github.com/search-github/getting-started-with-searching-on-github/understanding-the-search-syntax#query-for-dates).\&quot;</param>
        /// <param name="excludePullRequests">If &#x60;true&#x60; pull requests are omitted from the response (empty array).</param>
        /// <param name="checkSuiteId">Returns workflow runs with the &#x60;check_suite_id&#x60; that you specify.</param>
        /// <returns>ActionsListWorkflowRunsForRepo200Response</returns>
        ActionsListWorkflowRunsForRepo200Response ActionsListWorkflowRunsForRepo (string owner, string repo, string actor, string branch, string _event, string status, int? perPage, int? page, DateTime? created, bool? excludePullRequests, int? checkSuiteId);
        /// <summary>
        /// Re-run a job from a workflow run Re-run a job and its dependent jobs in a workflow run. You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;actions:write&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="jobId">The unique identifier of the job.</param>
        /// <param name="actionsReRunJobForWorkflowRunRequest"></param>
        /// <returns>Object</returns>
        Object ActionsReRunJobForWorkflowRun (string owner, string repo, int? jobId, ActionsReRunJobForWorkflowRunRequest actionsReRunJobForWorkflowRunRequest);
        /// <summary>
        /// Re-run a workflow Re-runs your workflow run using its &#x60;id&#x60;. You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;actions:write&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="runId">The unique identifier of the workflow run.</param>
        /// <param name="actionsReRunJobForWorkflowRunRequest"></param>
        /// <returns>Object</returns>
        Object ActionsReRunWorkflow (string owner, string repo, int? runId, ActionsReRunJobForWorkflowRunRequest actionsReRunJobForWorkflowRunRequest);
        /// <summary>
        /// Re-run failed jobs from a workflow run Re-run all of the failed jobs and their dependent jobs in a workflow run using the &#x60;id&#x60; of the workflow run. You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="runId">The unique identifier of the workflow run.</param>
        /// <param name="actionsReRunJobForWorkflowRunRequest"></param>
        /// <returns>Object</returns>
        Object ActionsReRunWorkflowFailedJobs (string owner, string repo, int? runId, ActionsReRunJobForWorkflowRunRequest actionsReRunJobForWorkflowRunRequest);
        /// <summary>
        /// Remove all custom labels from a self-hosted runner for an organization Remove all custom labels from a self-hosted runner configured in an organization. Returns the remaining read-only labels from the runner.  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="runnerId">Unique identifier of the self-hosted runner.</param>
        /// <returns>EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response</returns>
        EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response ActionsRemoveAllCustomLabelsFromSelfHostedRunnerForOrg (string org, int? runnerId);
        /// <summary>
        /// Remove all custom labels from a self-hosted runner for a repository Remove all custom labels from a self-hosted runner configured in a repository. Returns the remaining read-only labels from the runner.  You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="runnerId">Unique identifier of the self-hosted runner.</param>
        /// <returns>EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response</returns>
        EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response ActionsRemoveAllCustomLabelsFromSelfHostedRunnerForRepo (string owner, string repo, int? runnerId);
        /// <summary>
        /// Remove a custom label from a self-hosted runner for an organization Remove a custom label from a self-hosted runner configured in an organization. Returns the remaining labels from the runner.  This endpoint returns a &#x60;404 Not Found&#x60; status if the custom label is not present on the runner.  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="runnerId">Unique identifier of the self-hosted runner.</param>
        /// <param name="name">The name of a self-hosted runner&#39;s custom label.</param>
        /// <returns>EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response</returns>
        EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response ActionsRemoveCustomLabelFromSelfHostedRunnerForOrg (string org, int? runnerId, string name);
        /// <summary>
        /// Remove a custom label from a self-hosted runner for a repository Remove a custom label from a self-hosted runner configured in a repository. Returns the remaining labels from the runner.  This endpoint returns a &#x60;404 Not Found&#x60; status if the custom label is not present on the runner.  You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="runnerId">Unique identifier of the self-hosted runner.</param>
        /// <param name="name">The name of a self-hosted runner&#39;s custom label.</param>
        /// <returns>EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response</returns>
        EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response ActionsRemoveCustomLabelFromSelfHostedRunnerForRepo (string owner, string repo, int? runnerId, string name);
        /// <summary>
        /// Remove repository access to a self-hosted runner group in an organization The self-hosted runner groups REST API is available with GitHub Enterprise Cloud. For more information, see \&quot;[GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products).\&quot;   Removes a repository from the list of selected repositories that can access a self-hosted runner group. The runner group must have &#x60;visibility&#x60; set to &#x60;selected&#x60;. For more information, see \&quot;[Create a self-hosted runner group for an organization](#create-a-self-hosted-runner-group-for-an-organization).\&quot;  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="runnerGroupId">Unique identifier of the self-hosted runner group.</param>
        /// <param name="repositoryId">The unique identifier of the repository.</param>
        /// <returns></returns>
        void ActionsRemoveRepoAccessToSelfHostedRunnerGroupInOrg (string org, int? runnerGroupId, int? repositoryId);
        /// <summary>
        /// Remove selected repository from an organization secret Removes a repository from an organization secret when the &#x60;visibility&#x60; for repository access is set to &#x60;selected&#x60;. The visibility is set when you [Create or update an organization secret](https://docs.github.com/rest/reference/actions#create-or-update-an-organization-secret). You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;secrets&#x60; organization permission to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="secretName">The name of the secret.</param>
        /// <param name="repositoryId"></param>
        /// <returns></returns>
        void ActionsRemoveSelectedRepoFromOrgSecret (string org, string secretName, int? repositoryId);
        /// <summary>
        /// Remove a self-hosted runner from a group for an organization The self-hosted runner groups REST API is available with GitHub Enterprise Cloud. For more information, see \&quot;[GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products).\&quot;   Removes a self-hosted runner from a group configured in an organization. The runner is then returned to the default group.  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="runnerGroupId">Unique identifier of the self-hosted runner group.</param>
        /// <param name="runnerId">Unique identifier of the self-hosted runner.</param>
        /// <returns></returns>
        void ActionsRemoveSelfHostedRunnerFromGroupForOrg (string org, int? runnerGroupId, int? runnerId);
        /// <summary>
        /// Review pending deployments for a workflow run Approve or reject pending deployments that are waiting on approval by a required reviewer.  Required reviewers with read access to the repository contents and deployments can use this endpoint. Required reviewers must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="runId">The unique identifier of the workflow run.</param>
        /// <param name="actionsReviewPendingDeploymentsForRunRequest"></param>
        /// <returns>List&lt;Deployment&gt;</returns>
        List<Deployment> ActionsReviewPendingDeploymentsForRun (string owner, string repo, int? runId, ActionsReviewPendingDeploymentsForRunRequest actionsReviewPendingDeploymentsForRunRequest);
        /// <summary>
        /// Set the GitHub Actions OIDC custom issuer policy for an enterprise Sets the GitHub Actions OpenID Connect (OIDC) custom issuer policy for an enterprise. You must authenticate using an access token with the &#x60;admin:enterprise&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;enterprise_administration:write&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="actionsSetActionsOidcCustomIssuerPolicyForEnterpriseRequest"></param>
        /// <returns></returns>
        void ActionsSetActionsOidcCustomIssuerPolicyForEnterprise (string enterprise, ActionsSetActionsOidcCustomIssuerPolicyForEnterpriseRequest actionsSetActionsOidcCustomIssuerPolicyForEnterpriseRequest);
        /// <summary>
        /// Set allowed actions and reusable workflows for an organization Sets the actions and reusable workflows that are allowed in an organization. To use this endpoint, the organization permission policy for &#x60;allowed_actions&#x60; must be configured to &#x60;selected&#x60;. For more information, see \&quot;[Set GitHub Actions permissions for an organization](#set-github-actions-permissions-for-an-organization).\&quot;  If the organization belongs to an enterprise that has &#x60;selected&#x60; actions and reusable workflows set at the enterprise level, then you cannot override any of the enterprise&#39;s allowed actions and reusable workflows settings.  To use the &#x60;patterns_allowed&#x60; setting for private repositories, the organization must belong to an enterprise. If the organization does not belong to an enterprise, then the &#x60;patterns_allowed&#x60; setting only applies to public repositories in the organization.  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;administration&#x60; organization permission to use this API.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="enterpriseAdminGetAllowedActionsEnterprise200Response"></param>
        /// <returns></returns>
        void ActionsSetAllowedActionsOrganization (string org, EnterpriseAdminGetAllowedActionsEnterprise200Response enterpriseAdminGetAllowedActionsEnterprise200Response);
        /// <summary>
        /// Set allowed actions and reusable workflows for a repository Sets the actions and reusable workflows that are allowed in a repository. To use this endpoint, the repository permission policy for &#x60;allowed_actions&#x60; must be configured to &#x60;selected&#x60;. For more information, see \&quot;[Set GitHub Actions permissions for a repository](#set-github-actions-permissions-for-a-repository).\&quot;  If the repository belongs to an organization or enterprise that has &#x60;selected&#x60; actions and reusable workflows set at the organization or enterprise levels, then you cannot override any of the allowed actions and reusable workflows settings.  To use the &#x60;patterns_allowed&#x60; setting for private repositories, the repository must belong to an enterprise. If the repository does not belong to an enterprise, then the &#x60;patterns_allowed&#x60; setting only applies to public repositories.  You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;administration&#x60; repository permission to use this API.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="enterpriseAdminGetAllowedActionsEnterprise200Response"></param>
        /// <returns></returns>
        void ActionsSetAllowedActionsRepository (string owner, string repo, EnterpriseAdminGetAllowedActionsEnterprise200Response enterpriseAdminGetAllowedActionsEnterprise200Response);
        /// <summary>
        /// Set custom labels for a self-hosted runner for an organization Remove all previous custom labels and set the new custom labels for a specific self-hosted runner configured in an organization.  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="runnerId">Unique identifier of the self-hosted runner.</param>
        /// <param name="enterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest"></param>
        /// <returns>EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response</returns>
        EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response ActionsSetCustomLabelsForSelfHostedRunnerForOrg (string org, int? runnerId, EnterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest enterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest);
        /// <summary>
        /// Set custom labels for a self-hosted runner for a repository Remove all previous custom labels and set the new custom labels for a specific self-hosted runner configured in a repository.  You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="runnerId">Unique identifier of the self-hosted runner.</param>
        /// <param name="enterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest"></param>
        /// <returns>EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response</returns>
        EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response ActionsSetCustomLabelsForSelfHostedRunnerForRepo (string owner, string repo, int? runnerId, EnterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest enterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest);
        /// <summary>
        /// Set the opt-in flag of an OIDC subject claim customization for a repository Sets the &#x60;opt-in&#x60; or &#x60;opt-out&#x60; flag of a GitHub Actions OpenID Connect (OIDC) subject claim customization for a repository. You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;actions:write&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="theJsonPayloadEnablesDisablesTheUseOfSubClaimCustomization"></param>
        /// <returns>Object</returns>
        Object ActionsSetCustomOidcSubClaimForRepo (string owner, string repo, TheJsonPayloadEnablesDisablesTheUseOfSubClaimCustomization theJsonPayloadEnablesDisablesTheUseOfSubClaimCustomization);
        /// <summary>
        /// Set default workflow permissions for an enterprise Sets the default workflow permissions granted to the &#x60;GITHUB_TOKEN&#x60; when running workflows in an enterprise, and sets whether GitHub Actions can submit approving pull request reviews. For more information, see \&quot;[Enforcing a policy for workflow permissions in your enterprise](https://docs.github.com/enterprise-cloud@latest/admin/policies/enforcing-policies-for-your-enterprise/enforcing-policies-for-github-actions-in-your-enterprise#enforcing-a-policy-for-workflow-permissions-in-your-enterprise).\&quot;  You must authenticate using an access token with the &#x60;admin:enterprise&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;enterprise_administration:write&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="actionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest"></param>
        /// <returns></returns>
        void ActionsSetGithubActionsDefaultWorkflowPermissionsEnterprise (string enterprise, ActionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest actionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest);
        /// <summary>
        /// Set default workflow permissions for an organization Sets the default workflow permissions granted to the &#x60;GITHUB_TOKEN&#x60; when running workflows in an organization, and sets if GitHub Actions can submit approving pull request reviews. For more information, see \&quot;[Setting the permissions of the GITHUB_TOKEN for your organization](https://docs.github.com/organizations/managing-organization-settings/disabling-or-limiting-github-actions-for-your-organization#setting-the-permissions-of-the-github_token-for-your-organization).\&quot;  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;administration&#x60; organization permission to use this API.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="actionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest"></param>
        /// <returns></returns>
        void ActionsSetGithubActionsDefaultWorkflowPermissionsOrganization (string org, ActionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest actionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest);
        /// <summary>
        /// Set default workflow permissions for a repository Sets the default workflow permissions granted to the &#x60;GITHUB_TOKEN&#x60; when running workflows in a repository, and sets if GitHub Actions can submit approving pull request reviews. For more information, see \&quot;[Setting the permissions of the GITHUB_TOKEN for your repository](https://docs.github.com/repositories/managing-your-repositorys-settings-and-features/enabling-features-for-your-repository/managing-github-actions-settings-for-a-repository#setting-the-permissions-of-the-github_token-for-your-repository).\&quot;  You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the repository &#x60;administration&#x60; permission to use this API.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="actionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest"></param>
        /// <returns></returns>
        void ActionsSetGithubActionsDefaultWorkflowPermissionsRepository (string owner, string repo, ActionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest actionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest);
        /// <summary>
        /// Set GitHub Actions permissions for an organization Sets the GitHub Actions permissions policy for repositories and allowed actions and reusable workflows in an organization.  If the organization belongs to an enterprise that has set restrictive permissions at the enterprise level, such as &#x60;allowed_actions&#x60; to &#x60;selected&#x60; actions and reusable workflows, then you cannot override them for the organization.  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;administration&#x60; organization permission to use this API.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="actionsSetGithubActionsPermissionsOrganizationRequest"></param>
        /// <returns></returns>
        void ActionsSetGithubActionsPermissionsOrganization (string org, ActionsSetGithubActionsPermissionsOrganizationRequest actionsSetGithubActionsPermissionsOrganizationRequest);
        /// <summary>
        /// Set GitHub Actions permissions for a repository Sets the GitHub Actions permissions policy for enabling GitHub Actions and allowed actions and reusable workflows in the repository.  If the repository belongs to an organization or enterprise that has set restrictive permissions at the organization or enterprise levels, such as &#x60;allowed_actions&#x60; to &#x60;selected&#x60; actions and reusable workflows, then you cannot override them for the repository.  You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;administration&#x60; repository permission to use this API.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="actionsSetGithubActionsPermissionsRepositoryRequest"></param>
        /// <returns></returns>
        void ActionsSetGithubActionsPermissionsRepository (string owner, string repo, ActionsSetGithubActionsPermissionsRepositoryRequest actionsSetGithubActionsPermissionsRepositoryRequest);
        /// <summary>
        /// Set repository access for a self-hosted runner group in an organization The self-hosted runner groups REST API is available with GitHub Enterprise Cloud. For more information, see \&quot;[GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products).\&quot;  Replaces the list of repositories that have access to a self-hosted runner group configured in an organization.  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="runnerGroupId">Unique identifier of the self-hosted runner group.</param>
        /// <param name="actionsSetRepoAccessToSelfHostedRunnerGroupInOrgRequest"></param>
        /// <returns></returns>
        void ActionsSetRepoAccessToSelfHostedRunnerGroupInOrg (string org, int? runnerGroupId, ActionsSetRepoAccessToSelfHostedRunnerGroupInOrgRequest actionsSetRepoAccessToSelfHostedRunnerGroupInOrgRequest);
        /// <summary>
        /// Set selected repositories for an organization secret Replaces all repositories for an organization secret when the &#x60;visibility&#x60; for repository access is set to &#x60;selected&#x60;. The visibility is set when you [Create or update an organization secret](https://docs.github.com/rest/reference/actions#create-or-update-an-organization-secret). You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;secrets&#x60; organization permission to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="secretName">The name of the secret.</param>
        /// <param name="actionsSetSelectedReposForOrgSecretRequest"></param>
        /// <returns></returns>
        void ActionsSetSelectedReposForOrgSecret (string org, string secretName, ActionsSetSelectedReposForOrgSecretRequest actionsSetSelectedReposForOrgSecretRequest);
        /// <summary>
        /// Set selected repositories enabled for GitHub Actions in an organization Replaces the list of selected repositories that are enabled for GitHub Actions in an organization. To use this endpoint, the organization permission policy for &#x60;enabled_repositories&#x60; must be configured to &#x60;selected&#x60;. For more information, see \&quot;[Set GitHub Actions permissions for an organization](#set-github-actions-permissions-for-an-organization).\&quot;  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;administration&#x60; organization permission to use this API.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="actionsSetSelectedRepositoriesEnabledGithubActionsOrganizationRequest"></param>
        /// <returns></returns>
        void ActionsSetSelectedRepositoriesEnabledGithubActionsOrganization (string org, ActionsSetSelectedRepositoriesEnabledGithubActionsOrganizationRequest actionsSetSelectedRepositoriesEnabledGithubActionsOrganizationRequest);
        /// <summary>
        /// Set self-hosted runners in a group for an organization The self-hosted runner groups REST API is available with GitHub Enterprise Cloud. For more information, see \&quot;[GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products).\&quot;  Replaces the list of self-hosted runners that are part of an organization runner group.  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="runnerGroupId">Unique identifier of the self-hosted runner group.</param>
        /// <param name="enterpriseAdminSetSelfHostedRunnersInGroupForEnterpriseRequest"></param>
        /// <returns></returns>
        void ActionsSetSelfHostedRunnersInGroupForOrg (string org, int? runnerGroupId, EnterpriseAdminSetSelfHostedRunnersInGroupForEnterpriseRequest enterpriseAdminSetSelfHostedRunnersInGroupForEnterpriseRequest);
        /// <summary>
        /// Set the level of access for workflows outside of the repository Sets the level of access that workflows outside of the repository have to actions and reusable workflows in the repository. This endpoint only applies to internal repositories. For more information, see \&quot;[Managing GitHub Actions settings for a repository](https://docs.github.com/repositories/managing-your-repositorys-settings-and-features/enabling-features-for-your-repository/managing-github-actions-settings-for-a-repository#allowing-access-to-components-in-an-internal-repository).\&quot;  You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the repository &#x60;administration&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="actionsGetWorkflowAccessToRepository200Response"></param>
        /// <returns></returns>
        void ActionsSetWorkflowAccessToRepository (string owner, string repo, ActionsGetWorkflowAccessToRepository200Response actionsGetWorkflowAccessToRepository200Response);
        /// <summary>
        /// Update a self-hosted runner group for an organization The self-hosted runner groups REST API is available with GitHub Enterprise Cloud. For more information, see \&quot;[GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products).\&quot;  Updates the &#x60;name&#x60; and &#x60;visibility&#x60; of a self-hosted runner group in an organization.  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="runnerGroupId">Unique identifier of the self-hosted runner group.</param>
        /// <param name="actionsUpdateSelfHostedRunnerGroupForOrgRequest"></param>
        /// <returns>ActionsListSelfHostedRunnerGroupsForOrg200ResponseRunnerGroupsInner</returns>
        ActionsListSelfHostedRunnerGroupsForOrg200ResponseRunnerGroupsInner ActionsUpdateSelfHostedRunnerGroupForOrg (string org, int? runnerGroupId, ActionsUpdateSelfHostedRunnerGroupForOrgRequest actionsUpdateSelfHostedRunnerGroupForOrgRequest);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ActionsApi : IActionsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ActionsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ActionsApi(String basePath)
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
        /// Add custom labels to a self-hosted runner for an organization Add custom labels to a self-hosted runner configured in an organization.  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="runnerId">Unique identifier of the self-hosted runner.</param>
        /// <param name="enterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest"></param>
        /// <returns>EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response</returns>
        public EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response ActionsAddCustomLabelsToSelfHostedRunnerForOrg (string org, int? runnerId, EnterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest enterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling ActionsAddCustomLabelsToSelfHostedRunnerForOrg");
            
            // verify the required parameter 'runnerId' is set
            if (runnerId == null) throw new ApiException(400, "Missing required parameter 'runnerId' when calling ActionsAddCustomLabelsToSelfHostedRunnerForOrg");
            
            // verify the required parameter 'enterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest' is set
            if (enterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest == null) throw new ApiException(400, "Missing required parameter 'enterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest' when calling ActionsAddCustomLabelsToSelfHostedRunnerForOrg");
            

            var path = "/orgs/{org}/actions/runners/{runner_id}/labels";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "runner_id" + "}", ApiClient.ParameterToString(runnerId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(enterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsAddCustomLabelsToSelfHostedRunnerForOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsAddCustomLabelsToSelfHostedRunnerForOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response) ApiClient.Deserialize(response.Content, typeof(EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response), response.Headers);
        }

        /// <summary>
        /// Add custom labels to a self-hosted runner for a repository Add custom labels to a self-hosted runner configured in a repository.  You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="runnerId">Unique identifier of the self-hosted runner.</param>
        /// <param name="enterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest"></param>
        /// <returns>EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response</returns>
        public EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response ActionsAddCustomLabelsToSelfHostedRunnerForRepo (string owner, string repo, int? runnerId, EnterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest enterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActionsAddCustomLabelsToSelfHostedRunnerForRepo");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActionsAddCustomLabelsToSelfHostedRunnerForRepo");
            
            // verify the required parameter 'runnerId' is set
            if (runnerId == null) throw new ApiException(400, "Missing required parameter 'runnerId' when calling ActionsAddCustomLabelsToSelfHostedRunnerForRepo");
            
            // verify the required parameter 'enterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest' is set
            if (enterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest == null) throw new ApiException(400, "Missing required parameter 'enterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest' when calling ActionsAddCustomLabelsToSelfHostedRunnerForRepo");
            

            var path = "/repos/{owner}/{repo}/actions/runners/{runner_id}/labels";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "runner_id" + "}", ApiClient.ParameterToString(runnerId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(enterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsAddCustomLabelsToSelfHostedRunnerForRepo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsAddCustomLabelsToSelfHostedRunnerForRepo: " + response.ErrorMessage, response.ErrorMessage);

            return (EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response) ApiClient.Deserialize(response.Content, typeof(EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response), response.Headers);
        }

        /// <summary>
        /// Add repository access to a self-hosted runner group in an organization The self-hosted runner groups REST API is available with GitHub Enterprise Cloud. For more information, see \&quot;[GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products).\&quot;   Adds a repository to the list of selected repositories that can access a self-hosted runner group. The runner group must have &#x60;visibility&#x60; set to &#x60;selected&#x60;. For more information, see \&quot;[Create a self-hosted runner group for an organization](#create-a-self-hosted-runner-group-for-an-organization).\&quot;  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="runnerGroupId">Unique identifier of the self-hosted runner group.</param>
        /// <param name="repositoryId">The unique identifier of the repository.</param>
        /// <returns></returns>
        public void ActionsAddRepoAccessToSelfHostedRunnerGroupInOrg (string org, int? runnerGroupId, int? repositoryId)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling ActionsAddRepoAccessToSelfHostedRunnerGroupInOrg");
            
            // verify the required parameter 'runnerGroupId' is set
            if (runnerGroupId == null) throw new ApiException(400, "Missing required parameter 'runnerGroupId' when calling ActionsAddRepoAccessToSelfHostedRunnerGroupInOrg");
            
            // verify the required parameter 'repositoryId' is set
            if (repositoryId == null) throw new ApiException(400, "Missing required parameter 'repositoryId' when calling ActionsAddRepoAccessToSelfHostedRunnerGroupInOrg");
            

            var path = "/orgs/{org}/actions/runner-groups/{runner_group_id}/repositories/{repository_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "runner_group_id" + "}", ApiClient.ParameterToString(runnerGroupId));
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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsAddRepoAccessToSelfHostedRunnerGroupInOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsAddRepoAccessToSelfHostedRunnerGroupInOrg: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Add selected repository to an organization secret Adds a repository to an organization secret when the &#x60;visibility&#x60; for repository access is set to &#x60;selected&#x60;. The visibility is set when you [Create or update an organization secret](https://docs.github.com/rest/reference/actions#create-or-update-an-organization-secret). You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;secrets&#x60; organization permission to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="secretName">The name of the secret.</param>
        /// <param name="repositoryId"></param>
        /// <returns></returns>
        public void ActionsAddSelectedRepoToOrgSecret (string org, string secretName, int? repositoryId)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling ActionsAddSelectedRepoToOrgSecret");
            
            // verify the required parameter 'secretName' is set
            if (secretName == null) throw new ApiException(400, "Missing required parameter 'secretName' when calling ActionsAddSelectedRepoToOrgSecret");
            
            // verify the required parameter 'repositoryId' is set
            if (repositoryId == null) throw new ApiException(400, "Missing required parameter 'repositoryId' when calling ActionsAddSelectedRepoToOrgSecret");
            

            var path = "/orgs/{org}/actions/secrets/{secret_name}/repositories/{repository_id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsAddSelectedRepoToOrgSecret: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsAddSelectedRepoToOrgSecret: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Add a self-hosted runner to a group for an organization The self-hosted runner groups REST API is available with GitHub Enterprise Cloud. For more information, see \&quot;[GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products).\&quot;   Adds a self-hosted runner to a runner group configured in an organization.  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="runnerGroupId">Unique identifier of the self-hosted runner group.</param>
        /// <param name="runnerId">Unique identifier of the self-hosted runner.</param>
        /// <returns></returns>
        public void ActionsAddSelfHostedRunnerToGroupForOrg (string org, int? runnerGroupId, int? runnerId)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling ActionsAddSelfHostedRunnerToGroupForOrg");
            
            // verify the required parameter 'runnerGroupId' is set
            if (runnerGroupId == null) throw new ApiException(400, "Missing required parameter 'runnerGroupId' when calling ActionsAddSelfHostedRunnerToGroupForOrg");
            
            // verify the required parameter 'runnerId' is set
            if (runnerId == null) throw new ApiException(400, "Missing required parameter 'runnerId' when calling ActionsAddSelfHostedRunnerToGroupForOrg");
            

            var path = "/orgs/{org}/actions/runner-groups/{runner_group_id}/runners/{runner_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "runner_group_id" + "}", ApiClient.ParameterToString(runnerGroupId));
path = path.Replace("{" + "runner_id" + "}", ApiClient.ParameterToString(runnerId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsAddSelfHostedRunnerToGroupForOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsAddSelfHostedRunnerToGroupForOrg: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Approve a workflow run for a fork pull request Approves a workflow run for a pull request from a public fork of a first time contributor. For more information, see [\&quot;Approving workflow runs from public forks](https://docs.github.com/actions/managing-workflow-runs/approving-workflow-runs-from-public-forks).\&quot;  You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;actions:write&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="runId">The unique identifier of the workflow run.</param>
        /// <returns>Object</returns>
        public Object ActionsApproveWorkflowRun (string owner, string repo, int? runId)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActionsApproveWorkflowRun");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActionsApproveWorkflowRun");
            
            // verify the required parameter 'runId' is set
            if (runId == null) throw new ApiException(400, "Missing required parameter 'runId' when calling ActionsApproveWorkflowRun");
            

            var path = "/repos/{owner}/{repo}/actions/runs/{run_id}/approve";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "run_id" + "}", ApiClient.ParameterToString(runId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsApproveWorkflowRun: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsApproveWorkflowRun: " + response.ErrorMessage, response.ErrorMessage);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }

        /// <summary>
        /// Cancel a workflow run Cancels a workflow run using its &#x60;id&#x60;. You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;actions:write&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="runId">The unique identifier of the workflow run.</param>
        /// <returns>Object</returns>
        public Object ActionsCancelWorkflowRun (string owner, string repo, int? runId)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActionsCancelWorkflowRun");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActionsCancelWorkflowRun");
            
            // verify the required parameter 'runId' is set
            if (runId == null) throw new ApiException(400, "Missing required parameter 'runId' when calling ActionsCancelWorkflowRun");
            

            var path = "/repos/{owner}/{repo}/actions/runs/{run_id}/cancel";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "run_id" + "}", ApiClient.ParameterToString(runId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsCancelWorkflowRun: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsCancelWorkflowRun: " + response.ErrorMessage, response.ErrorMessage);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }

        /// <summary>
        /// Create or update an environment secret Creates or updates an environment secret with an encrypted value. Encrypt your secret using [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages). You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;secrets&#x60; repository permission to use this endpoint.  #### Example encrypting a secret using Node.js  Encrypt your secret using the [tweetsodium](https://github.com/github/tweetsodium) library.  &#x60;&#x60;&#x60; const sodium &#x3D; require(&#39;tweetsodium&#39;);  const key &#x3D; \&quot;base64-encoded-public-key\&quot;; const value &#x3D; \&quot;plain-text-secret\&quot;;  // Convert the message and key to Uint8Array&#39;s (Buffer implements that interface) const messageBytes &#x3D; Buffer.from(value); const keyBytes &#x3D; Buffer.from(key, &#39;base64&#39;);  // Encrypt using LibSodium. const encryptedBytes &#x3D; sodium.seal(messageBytes, keyBytes);  // Base64 the encrypted secret const encrypted &#x3D; Buffer.from(encryptedBytes).toString(&#39;base64&#39;);  console.log(encrypted); &#x60;&#x60;&#x60;   #### Example encrypting a secret using Python  Encrypt your secret using [pynacl](https://pynacl.readthedocs.io/en/latest/public/#nacl-public-sealedbox) with Python 3.  &#x60;&#x60;&#x60; from base64 import b64encode from nacl import encoding, public  def encrypt(public_key: str, secret_value: str) -&gt; str:   \&quot;\&quot;\&quot;Encrypt a Unicode string using the public key.\&quot;\&quot;\&quot;   public_key &#x3D; public.PublicKey(public_key.encode(\&quot;utf-8\&quot;), encoding.Base64Encoder())   sealed_box &#x3D; public.SealedBox(public_key)   encrypted &#x3D; sealed_box.encrypt(secret_value.encode(\&quot;utf-8\&quot;))   return b64encode(encrypted).decode(\&quot;utf-8\&quot;) &#x60;&#x60;&#x60;  #### Example encrypting a secret using C#  Encrypt your secret using the [Sodium.Core](https://www.nuget.org/packages/Sodium.Core/) package.  &#x60;&#x60;&#x60; var secretValue &#x3D; System.Text.Encoding.UTF8.GetBytes(\&quot;mySecret\&quot;); var publicKey &#x3D; Convert.FromBase64String(\&quot;2Sg8iYjAxxmI2LvUXpJjkYrMxURPc8r+dB7TJyvvcCU&#x3D;\&quot;);  var sealedPublicKeyBox &#x3D; Sodium.SealedPublicKeyBox.Create(secretValue, publicKey);  Console.WriteLine(Convert.ToBase64String(sealedPublicKeyBox)); &#x60;&#x60;&#x60;  #### Example encrypting a secret using Ruby  Encrypt your secret using the [rbnacl](https://github.com/RubyCrypto/rbnacl) gem.  &#x60;&#x60;&#x60;ruby require \&quot;rbnacl\&quot; require \&quot;base64\&quot;  key &#x3D; Base64.decode64(\&quot;+ZYvJDZMHUfBkJdyq5Zm9SKqeuBQ4sj+6sfjlH4CgG0&#x3D;\&quot;) public_key &#x3D; RbNaCl::PublicKey.new(key)  box &#x3D; RbNaCl::Boxes::Sealed.from_public_key(public_key) encrypted_secret &#x3D; box.encrypt(\&quot;my_secret\&quot;)  # Print the base64 encoded secret puts Base64.strict_encode64(encrypted_secret) &#x60;&#x60;&#x60;
        /// </summary>
        /// <param name="repositoryId">The unique identifier of the repository.</param>
        /// <param name="environmentName">The name of the environment</param>
        /// <param name="secretName">The name of the secret.</param>
        /// <param name="actionsCreateOrUpdateEnvironmentSecretRequest"></param>
        /// <returns>Object</returns>
        public Object ActionsCreateOrUpdateEnvironmentSecret (int? repositoryId, string environmentName, string secretName, ActionsCreateOrUpdateEnvironmentSecretRequest actionsCreateOrUpdateEnvironmentSecretRequest)
        {
            
            // verify the required parameter 'repositoryId' is set
            if (repositoryId == null) throw new ApiException(400, "Missing required parameter 'repositoryId' when calling ActionsCreateOrUpdateEnvironmentSecret");
            
            // verify the required parameter 'environmentName' is set
            if (environmentName == null) throw new ApiException(400, "Missing required parameter 'environmentName' when calling ActionsCreateOrUpdateEnvironmentSecret");
            
            // verify the required parameter 'secretName' is set
            if (secretName == null) throw new ApiException(400, "Missing required parameter 'secretName' when calling ActionsCreateOrUpdateEnvironmentSecret");
            
            // verify the required parameter 'actionsCreateOrUpdateEnvironmentSecretRequest' is set
            if (actionsCreateOrUpdateEnvironmentSecretRequest == null) throw new ApiException(400, "Missing required parameter 'actionsCreateOrUpdateEnvironmentSecretRequest' when calling ActionsCreateOrUpdateEnvironmentSecret");
            

            var path = "/repositories/{repository_id}/environments/{environment_name}/secrets/{secret_name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "repository_id" + "}", ApiClient.ParameterToString(repositoryId));
path = path.Replace("{" + "environment_name" + "}", ApiClient.ParameterToString(environmentName));
path = path.Replace("{" + "secret_name" + "}", ApiClient.ParameterToString(secretName));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(actionsCreateOrUpdateEnvironmentSecretRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsCreateOrUpdateEnvironmentSecret: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsCreateOrUpdateEnvironmentSecret: " + response.ErrorMessage, response.ErrorMessage);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }

        /// <summary>
        /// Create or update an organization secret Creates or updates an organization secret with an encrypted value. Encrypt your secret using [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages). You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;secrets&#x60; organization permission to use this endpoint.  #### Example encrypting a secret using Node.js  Encrypt your secret using the [tweetsodium](https://github.com/github/tweetsodium) library.  &#x60;&#x60;&#x60; const sodium &#x3D; require(&#39;tweetsodium&#39;);  const key &#x3D; \&quot;base64-encoded-public-key\&quot;; const value &#x3D; \&quot;plain-text-secret\&quot;;  // Convert the message and key to Uint8Array&#39;s (Buffer implements that interface) const messageBytes &#x3D; Buffer.from(value); const keyBytes &#x3D; Buffer.from(key, &#39;base64&#39;);  // Encrypt using LibSodium. const encryptedBytes &#x3D; sodium.seal(messageBytes, keyBytes);  // Base64 the encrypted secret const encrypted &#x3D; Buffer.from(encryptedBytes).toString(&#39;base64&#39;);  console.log(encrypted); &#x60;&#x60;&#x60;   #### Example encrypting a secret using Python  Encrypt your secret using [pynacl](https://pynacl.readthedocs.io/en/latest/public/#nacl-public-sealedbox) with Python 3.  &#x60;&#x60;&#x60; from base64 import b64encode from nacl import encoding, public  def encrypt(public_key: str, secret_value: str) -&gt; str:   \&quot;\&quot;\&quot;Encrypt a Unicode string using the public key.\&quot;\&quot;\&quot;   public_key &#x3D; public.PublicKey(public_key.encode(\&quot;utf-8\&quot;), encoding.Base64Encoder())   sealed_box &#x3D; public.SealedBox(public_key)   encrypted &#x3D; sealed_box.encrypt(secret_value.encode(\&quot;utf-8\&quot;))   return b64encode(encrypted).decode(\&quot;utf-8\&quot;) &#x60;&#x60;&#x60;  #### Example encrypting a secret using C#  Encrypt your secret using the [Sodium.Core](https://www.nuget.org/packages/Sodium.Core/) package.  &#x60;&#x60;&#x60; var secretValue &#x3D; System.Text.Encoding.UTF8.GetBytes(\&quot;mySecret\&quot;); var publicKey &#x3D; Convert.FromBase64String(\&quot;2Sg8iYjAxxmI2LvUXpJjkYrMxURPc8r+dB7TJyvvcCU&#x3D;\&quot;);  var sealedPublicKeyBox &#x3D; Sodium.SealedPublicKeyBox.Create(secretValue, publicKey);  Console.WriteLine(Convert.ToBase64String(sealedPublicKeyBox)); &#x60;&#x60;&#x60;  #### Example encrypting a secret using Ruby  Encrypt your secret using the [rbnacl](https://github.com/RubyCrypto/rbnacl) gem.  &#x60;&#x60;&#x60;ruby require \&quot;rbnacl\&quot; require \&quot;base64\&quot;  key &#x3D; Base64.decode64(\&quot;+ZYvJDZMHUfBkJdyq5Zm9SKqeuBQ4sj+6sfjlH4CgG0&#x3D;\&quot;) public_key &#x3D; RbNaCl::PublicKey.new(key)  box &#x3D; RbNaCl::Boxes::Sealed.from_public_key(public_key) encrypted_secret &#x3D; box.encrypt(\&quot;my_secret\&quot;)  # Print the base64 encoded secret puts Base64.strict_encode64(encrypted_secret) &#x60;&#x60;&#x60;
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="secretName">The name of the secret.</param>
        /// <param name="actionsCreateOrUpdateOrgSecretRequest"></param>
        /// <returns>Object</returns>
        public Object ActionsCreateOrUpdateOrgSecret (string org, string secretName, ActionsCreateOrUpdateOrgSecretRequest actionsCreateOrUpdateOrgSecretRequest)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling ActionsCreateOrUpdateOrgSecret");
            
            // verify the required parameter 'secretName' is set
            if (secretName == null) throw new ApiException(400, "Missing required parameter 'secretName' when calling ActionsCreateOrUpdateOrgSecret");
            
            // verify the required parameter 'actionsCreateOrUpdateOrgSecretRequest' is set
            if (actionsCreateOrUpdateOrgSecretRequest == null) throw new ApiException(400, "Missing required parameter 'actionsCreateOrUpdateOrgSecretRequest' when calling ActionsCreateOrUpdateOrgSecret");
            

            var path = "/orgs/{org}/actions/secrets/{secret_name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "secret_name" + "}", ApiClient.ParameterToString(secretName));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(actionsCreateOrUpdateOrgSecretRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsCreateOrUpdateOrgSecret: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsCreateOrUpdateOrgSecret: " + response.ErrorMessage, response.ErrorMessage);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }

        /// <summary>
        /// Create or update a repository secret Creates or updates a repository secret with an encrypted value. Encrypt your secret using [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages). You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;secrets&#x60; repository permission to use this endpoint.  #### Example encrypting a secret using Node.js  Encrypt your secret using the [tweetsodium](https://github.com/github/tweetsodium) library.  &#x60;&#x60;&#x60; const sodium &#x3D; require(&#39;tweetsodium&#39;);  const key &#x3D; \&quot;base64-encoded-public-key\&quot;; const value &#x3D; \&quot;plain-text-secret\&quot;;  // Convert the message and key to Uint8Array&#39;s (Buffer implements that interface) const messageBytes &#x3D; Buffer.from(value); const keyBytes &#x3D; Buffer.from(key, &#39;base64&#39;);  // Encrypt using LibSodium. const encryptedBytes &#x3D; sodium.seal(messageBytes, keyBytes);  // Base64 the encrypted secret const encrypted &#x3D; Buffer.from(encryptedBytes).toString(&#39;base64&#39;);  console.log(encrypted); &#x60;&#x60;&#x60;   #### Example encrypting a secret using Python  Encrypt your secret using [pynacl](https://pynacl.readthedocs.io/en/latest/public/#nacl-public-sealedbox) with Python 3.  &#x60;&#x60;&#x60; from base64 import b64encode from nacl import encoding, public  def encrypt(public_key: str, secret_value: str) -&gt; str:   \&quot;\&quot;\&quot;Encrypt a Unicode string using the public key.\&quot;\&quot;\&quot;   public_key &#x3D; public.PublicKey(public_key.encode(\&quot;utf-8\&quot;), encoding.Base64Encoder())   sealed_box &#x3D; public.SealedBox(public_key)   encrypted &#x3D; sealed_box.encrypt(secret_value.encode(\&quot;utf-8\&quot;))   return b64encode(encrypted).decode(\&quot;utf-8\&quot;) &#x60;&#x60;&#x60;  #### Example encrypting a secret using C#  Encrypt your secret using the [Sodium.Core](https://www.nuget.org/packages/Sodium.Core/) package.  &#x60;&#x60;&#x60; var secretValue &#x3D; System.Text.Encoding.UTF8.GetBytes(\&quot;mySecret\&quot;); var publicKey &#x3D; Convert.FromBase64String(\&quot;2Sg8iYjAxxmI2LvUXpJjkYrMxURPc8r+dB7TJyvvcCU&#x3D;\&quot;);  var sealedPublicKeyBox &#x3D; Sodium.SealedPublicKeyBox.Create(secretValue, publicKey);  Console.WriteLine(Convert.ToBase64String(sealedPublicKeyBox)); &#x60;&#x60;&#x60;  #### Example encrypting a secret using Ruby  Encrypt your secret using the [rbnacl](https://github.com/RubyCrypto/rbnacl) gem.  &#x60;&#x60;&#x60;ruby require \&quot;rbnacl\&quot; require \&quot;base64\&quot;  key &#x3D; Base64.decode64(\&quot;+ZYvJDZMHUfBkJdyq5Zm9SKqeuBQ4sj+6sfjlH4CgG0&#x3D;\&quot;) public_key &#x3D; RbNaCl::PublicKey.new(key)  box &#x3D; RbNaCl::Boxes::Sealed.from_public_key(public_key) encrypted_secret &#x3D; box.encrypt(\&quot;my_secret\&quot;)  # Print the base64 encoded secret puts Base64.strict_encode64(encrypted_secret) &#x60;&#x60;&#x60;
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="secretName">The name of the secret.</param>
        /// <param name="actionsCreateOrUpdateRepoSecretRequest"></param>
        /// <returns>Object</returns>
        public Object ActionsCreateOrUpdateRepoSecret (string owner, string repo, string secretName, ActionsCreateOrUpdateRepoSecretRequest actionsCreateOrUpdateRepoSecretRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActionsCreateOrUpdateRepoSecret");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActionsCreateOrUpdateRepoSecret");
            
            // verify the required parameter 'secretName' is set
            if (secretName == null) throw new ApiException(400, "Missing required parameter 'secretName' when calling ActionsCreateOrUpdateRepoSecret");
            
            // verify the required parameter 'actionsCreateOrUpdateRepoSecretRequest' is set
            if (actionsCreateOrUpdateRepoSecretRequest == null) throw new ApiException(400, "Missing required parameter 'actionsCreateOrUpdateRepoSecretRequest' when calling ActionsCreateOrUpdateRepoSecret");
            

            var path = "/repos/{owner}/{repo}/actions/secrets/{secret_name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "secret_name" + "}", ApiClient.ParameterToString(secretName));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(actionsCreateOrUpdateRepoSecretRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsCreateOrUpdateRepoSecret: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsCreateOrUpdateRepoSecret: " + response.ErrorMessage, response.ErrorMessage);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }

        /// <summary>
        /// Create a registration token for an organization Returns a token that you can pass to the &#x60;config&#x60; script. The token expires after one hour.  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint.  #### Example using registration token  Configure your self-hosted runner, replacing &#x60;TOKEN&#x60; with the registration token provided by this endpoint.  &#x60;&#x60;&#x60; ./config.sh - -url https://github.com/octo-org - -token TOKEN &#x60;&#x60;&#x60;
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <returns>AuthenticationToken</returns>
        public AuthenticationToken ActionsCreateRegistrationTokenForOrg (string org)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling ActionsCreateRegistrationTokenForOrg");
            

            var path = "/orgs/{org}/actions/runners/registration-token";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsCreateRegistrationTokenForOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsCreateRegistrationTokenForOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (AuthenticationToken) ApiClient.Deserialize(response.Content, typeof(AuthenticationToken), response.Headers);
        }

        /// <summary>
        /// Create a registration token for a repository Returns a token that you can pass to the &#x60;config&#x60; script. The token expires after one hour. You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint.  #### Example using registration token   Configure your self-hosted runner, replacing &#x60;TOKEN&#x60; with the registration token provided by this endpoint.  &#x60;&#x60;&#x60; ./config.sh - -url https://github.com/octo-org/octo-repo-artifacts - -token TOKEN &#x60;&#x60;&#x60;
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>AuthenticationToken</returns>
        public AuthenticationToken ActionsCreateRegistrationTokenForRepo (string owner, string repo)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActionsCreateRegistrationTokenForRepo");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActionsCreateRegistrationTokenForRepo");
            

            var path = "/repos/{owner}/{repo}/actions/runners/registration-token";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsCreateRegistrationTokenForRepo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsCreateRegistrationTokenForRepo: " + response.ErrorMessage, response.ErrorMessage);

            return (AuthenticationToken) ApiClient.Deserialize(response.Content, typeof(AuthenticationToken), response.Headers);
        }

        /// <summary>
        /// Create a remove token for an organization Returns a token that you can pass to the &#x60;config&#x60; script to remove a self-hosted runner from an organization. The token expires after one hour.  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint.  #### Example using remove token  To remove your self-hosted runner from an organization, replace &#x60;TOKEN&#x60; with the remove token provided by this endpoint.  &#x60;&#x60;&#x60; ./config.sh remove - -token TOKEN &#x60;&#x60;&#x60;
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <returns>AuthenticationToken</returns>
        public AuthenticationToken ActionsCreateRemoveTokenForOrg (string org)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling ActionsCreateRemoveTokenForOrg");
            

            var path = "/orgs/{org}/actions/runners/remove-token";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsCreateRemoveTokenForOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsCreateRemoveTokenForOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (AuthenticationToken) ApiClient.Deserialize(response.Content, typeof(AuthenticationToken), response.Headers);
        }

        /// <summary>
        /// Create a remove token for a repository Returns a token that you can pass to remove a self-hosted runner from a repository. The token expires after one hour. You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint.  #### Example using remove token   To remove your self-hosted runner from a repository, replace TOKEN with the remove token provided by this endpoint.  &#x60;&#x60;&#x60; ./config.sh remove - -token TOKEN &#x60;&#x60;&#x60;
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>AuthenticationToken</returns>
        public AuthenticationToken ActionsCreateRemoveTokenForRepo (string owner, string repo)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActionsCreateRemoveTokenForRepo");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActionsCreateRemoveTokenForRepo");
            

            var path = "/repos/{owner}/{repo}/actions/runners/remove-token";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsCreateRemoveTokenForRepo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsCreateRemoveTokenForRepo: " + response.ErrorMessage, response.ErrorMessage);

            return (AuthenticationToken) ApiClient.Deserialize(response.Content, typeof(AuthenticationToken), response.Headers);
        }

        /// <summary>
        /// Create a self-hosted runner group for an organization The self-hosted runner groups REST API is available with GitHub Enterprise Cloud and GitHub Enterprise Server. For more information, see \&quot;[GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products).\&quot;  Creates a new self-hosted runner group for an organization.  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="actionsCreateSelfHostedRunnerGroupForOrgRequest"></param>
        /// <returns>ActionsListSelfHostedRunnerGroupsForOrg200ResponseRunnerGroupsInner</returns>
        public ActionsListSelfHostedRunnerGroupsForOrg200ResponseRunnerGroupsInner ActionsCreateSelfHostedRunnerGroupForOrg (string org, ActionsCreateSelfHostedRunnerGroupForOrgRequest actionsCreateSelfHostedRunnerGroupForOrgRequest)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling ActionsCreateSelfHostedRunnerGroupForOrg");
            
            // verify the required parameter 'actionsCreateSelfHostedRunnerGroupForOrgRequest' is set
            if (actionsCreateSelfHostedRunnerGroupForOrgRequest == null) throw new ApiException(400, "Missing required parameter 'actionsCreateSelfHostedRunnerGroupForOrgRequest' when calling ActionsCreateSelfHostedRunnerGroupForOrg");
            

            var path = "/orgs/{org}/actions/runner-groups";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(actionsCreateSelfHostedRunnerGroupForOrgRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsCreateSelfHostedRunnerGroupForOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsCreateSelfHostedRunnerGroupForOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (ActionsListSelfHostedRunnerGroupsForOrg200ResponseRunnerGroupsInner) ApiClient.Deserialize(response.Content, typeof(ActionsListSelfHostedRunnerGroupsForOrg200ResponseRunnerGroupsInner), response.Headers);
        }

        /// <summary>
        /// Create a workflow dispatch event You can use this endpoint to manually trigger a GitHub Actions workflow run. You can replace &#x60;workflow_id&#x60; with the workflow file name. For example, you could use &#x60;main.yaml&#x60;.  You must configure your GitHub Actions workflow to run when the [&#x60;workflow_dispatch&#x60; webhook](/developers/webhooks-and-events/webhook-events-and-payloads#workflow_dispatch) event occurs. The &#x60;inputs&#x60; are configured in the workflow file. For more information about how to configure the &#x60;workflow_dispatch&#x60; event in the workflow file, see \&quot;[Events that trigger workflows](/actions/reference/events-that-trigger-workflows#workflow_dispatch).\&quot;  You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;actions:write&#x60; permission to use this endpoint. For more information, see \&quot;[Creating a personal access token for the command line](https://docs.github.com/articles/creating-a-personal-access-token-for-the-command-line).\&quot;
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="workflowId">The ID of the workflow. You can also pass the workflow file name as a string.</param>
        /// <param name="actionsCreateWorkflowDispatchRequest"></param>
        /// <returns></returns>
        public void ActionsCreateWorkflowDispatch (string owner, string repo, ActionsGetWorkflowWorkflowIdParameter workflowId, ActionsCreateWorkflowDispatchRequest actionsCreateWorkflowDispatchRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActionsCreateWorkflowDispatch");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActionsCreateWorkflowDispatch");
            
            // verify the required parameter 'workflowId' is set
            if (workflowId == null) throw new ApiException(400, "Missing required parameter 'workflowId' when calling ActionsCreateWorkflowDispatch");
            
            // verify the required parameter 'actionsCreateWorkflowDispatchRequest' is set
            if (actionsCreateWorkflowDispatchRequest == null) throw new ApiException(400, "Missing required parameter 'actionsCreateWorkflowDispatchRequest' when calling ActionsCreateWorkflowDispatch");
            

            var path = "/repos/{owner}/{repo}/actions/workflows/{workflow_id}/dispatches";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "workflow_id" + "}", ApiClient.ParameterToString(workflowId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(actionsCreateWorkflowDispatchRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsCreateWorkflowDispatch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsCreateWorkflowDispatch: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Delete a GitHub Actions cache for a repository (using a cache ID) Deletes a GitHub Actions cache for a repository, using a cache ID.  You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint.  GitHub Apps must have the &#x60;actions:write&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="cacheId">The unique identifier of the GitHub Actions cache.</param>
        /// <returns></returns>
        public void ActionsDeleteActionsCacheById (string owner, string repo, int? cacheId)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActionsDeleteActionsCacheById");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActionsDeleteActionsCacheById");
            
            // verify the required parameter 'cacheId' is set
            if (cacheId == null) throw new ApiException(400, "Missing required parameter 'cacheId' when calling ActionsDeleteActionsCacheById");
            

            var path = "/repos/{owner}/{repo}/actions/caches/{cache_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "cache_id" + "}", ApiClient.ParameterToString(cacheId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsDeleteActionsCacheById: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsDeleteActionsCacheById: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Delete GitHub Actions caches for a repository (using a cache key) Deletes one or more GitHub Actions caches for a repository, using a complete cache key. By default, all caches that match the provided key are deleted, but you can optionally provide a Git ref to restrict deletions to caches that match both the provided key and the Git ref.  You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint.  GitHub Apps must have the &#x60;actions:write&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="key">A key for identifying the cache.</param>
        /// <param name="_ref">The Git reference for the results you want to list. The &#x60;ref&#x60; for a branch can be formatted either as &#x60;refs/heads/&lt;branch name&gt;&#x60; or simply &#x60;&lt;branch name&gt;&#x60;. To reference a pull request use &#x60;refs/pull/&lt;number&gt;/merge&#x60;.</param>
        /// <returns>RepositoryActionsCaches</returns>
        public RepositoryActionsCaches ActionsDeleteActionsCacheByKey (string owner, string repo, string key, string _ref)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActionsDeleteActionsCacheByKey");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActionsDeleteActionsCacheByKey");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling ActionsDeleteActionsCacheByKey");
            

            var path = "/repos/{owner}/{repo}/actions/caches";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
 if (_ref != null) queryParams.Add("ref", ApiClient.ParameterToString(_ref)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsDeleteActionsCacheByKey: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsDeleteActionsCacheByKey: " + response.ErrorMessage, response.ErrorMessage);

            return (RepositoryActionsCaches) ApiClient.Deserialize(response.Content, typeof(RepositoryActionsCaches), response.Headers);
        }

        /// <summary>
        /// Delete an artifact Deletes an artifact for a workflow run. You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;actions:write&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="artifactId">The unique identifier of the artifact.</param>
        /// <returns></returns>
        public void ActionsDeleteArtifact (string owner, string repo, int? artifactId)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActionsDeleteArtifact");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActionsDeleteArtifact");
            
            // verify the required parameter 'artifactId' is set
            if (artifactId == null) throw new ApiException(400, "Missing required parameter 'artifactId' when calling ActionsDeleteArtifact");
            

            var path = "/repos/{owner}/{repo}/actions/artifacts/{artifact_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "artifact_id" + "}", ApiClient.ParameterToString(artifactId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsDeleteArtifact: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsDeleteArtifact: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Delete an environment secret Deletes a secret in an environment using the secret name. You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;secrets&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="repositoryId">The unique identifier of the repository.</param>
        /// <param name="environmentName">The name of the environment</param>
        /// <param name="secretName">The name of the secret.</param>
        /// <returns></returns>
        public void ActionsDeleteEnvironmentSecret (int? repositoryId, string environmentName, string secretName)
        {
            
            // verify the required parameter 'repositoryId' is set
            if (repositoryId == null) throw new ApiException(400, "Missing required parameter 'repositoryId' when calling ActionsDeleteEnvironmentSecret");
            
            // verify the required parameter 'environmentName' is set
            if (environmentName == null) throw new ApiException(400, "Missing required parameter 'environmentName' when calling ActionsDeleteEnvironmentSecret");
            
            // verify the required parameter 'secretName' is set
            if (secretName == null) throw new ApiException(400, "Missing required parameter 'secretName' when calling ActionsDeleteEnvironmentSecret");
            

            var path = "/repositories/{repository_id}/environments/{environment_name}/secrets/{secret_name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "repository_id" + "}", ApiClient.ParameterToString(repositoryId));
path = path.Replace("{" + "environment_name" + "}", ApiClient.ParameterToString(environmentName));
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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsDeleteEnvironmentSecret: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsDeleteEnvironmentSecret: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Delete an organization secret Deletes a secret in an organization using the secret name. You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;secrets&#x60; organization permission to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="secretName">The name of the secret.</param>
        /// <returns></returns>
        public void ActionsDeleteOrgSecret (string org, string secretName)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling ActionsDeleteOrgSecret");
            
            // verify the required parameter 'secretName' is set
            if (secretName == null) throw new ApiException(400, "Missing required parameter 'secretName' when calling ActionsDeleteOrgSecret");
            

            var path = "/orgs/{org}/actions/secrets/{secret_name}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsDeleteOrgSecret: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsDeleteOrgSecret: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Delete a repository secret Deletes a secret in a repository using the secret name. You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;secrets&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="secretName">The name of the secret.</param>
        /// <returns></returns>
        public void ActionsDeleteRepoSecret (string owner, string repo, string secretName)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActionsDeleteRepoSecret");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActionsDeleteRepoSecret");
            
            // verify the required parameter 'secretName' is set
            if (secretName == null) throw new ApiException(400, "Missing required parameter 'secretName' when calling ActionsDeleteRepoSecret");
            

            var path = "/repos/{owner}/{repo}/actions/secrets/{secret_name}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsDeleteRepoSecret: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsDeleteRepoSecret: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Delete a self-hosted runner from an organization Forces the removal of a self-hosted runner from an organization. You can use this endpoint to completely remove the runner when the machine you were using no longer exists.  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="runnerId">Unique identifier of the self-hosted runner.</param>
        /// <returns></returns>
        public void ActionsDeleteSelfHostedRunnerFromOrg (string org, int? runnerId)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling ActionsDeleteSelfHostedRunnerFromOrg");
            
            // verify the required parameter 'runnerId' is set
            if (runnerId == null) throw new ApiException(400, "Missing required parameter 'runnerId' when calling ActionsDeleteSelfHostedRunnerFromOrg");
            

            var path = "/orgs/{org}/actions/runners/{runner_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "runner_id" + "}", ApiClient.ParameterToString(runnerId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsDeleteSelfHostedRunnerFromOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsDeleteSelfHostedRunnerFromOrg: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Delete a self-hosted runner from a repository Forces the removal of a self-hosted runner from a repository. You can use this endpoint to completely remove the runner when the machine you were using no longer exists.  You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="runnerId">Unique identifier of the self-hosted runner.</param>
        /// <returns></returns>
        public void ActionsDeleteSelfHostedRunnerFromRepo (string owner, string repo, int? runnerId)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActionsDeleteSelfHostedRunnerFromRepo");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActionsDeleteSelfHostedRunnerFromRepo");
            
            // verify the required parameter 'runnerId' is set
            if (runnerId == null) throw new ApiException(400, "Missing required parameter 'runnerId' when calling ActionsDeleteSelfHostedRunnerFromRepo");
            

            var path = "/repos/{owner}/{repo}/actions/runners/{runner_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "runner_id" + "}", ApiClient.ParameterToString(runnerId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsDeleteSelfHostedRunnerFromRepo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsDeleteSelfHostedRunnerFromRepo: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Delete a self-hosted runner group from an organization The self-hosted runner groups REST API is available with GitHub Enterprise Cloud. For more information, see \&quot;[GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products).\&quot;  Deletes a self-hosted runner group for an organization.  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="runnerGroupId">Unique identifier of the self-hosted runner group.</param>
        /// <returns></returns>
        public void ActionsDeleteSelfHostedRunnerGroupFromOrg (string org, int? runnerGroupId)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling ActionsDeleteSelfHostedRunnerGroupFromOrg");
            
            // verify the required parameter 'runnerGroupId' is set
            if (runnerGroupId == null) throw new ApiException(400, "Missing required parameter 'runnerGroupId' when calling ActionsDeleteSelfHostedRunnerGroupFromOrg");
            

            var path = "/orgs/{org}/actions/runner-groups/{runner_group_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "runner_group_id" + "}", ApiClient.ParameterToString(runnerGroupId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsDeleteSelfHostedRunnerGroupFromOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsDeleteSelfHostedRunnerGroupFromOrg: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Delete a workflow run Delete a specific workflow run. Anyone with write access to the repository can use this endpoint. If the repository is private you must use an access token with the &#x60;repo&#x60; scope. GitHub Apps must have the &#x60;actions:write&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="runId">The unique identifier of the workflow run.</param>
        /// <returns></returns>
        public void ActionsDeleteWorkflowRun (string owner, string repo, int? runId)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActionsDeleteWorkflowRun");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActionsDeleteWorkflowRun");
            
            // verify the required parameter 'runId' is set
            if (runId == null) throw new ApiException(400, "Missing required parameter 'runId' when calling ActionsDeleteWorkflowRun");
            

            var path = "/repos/{owner}/{repo}/actions/runs/{run_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "run_id" + "}", ApiClient.ParameterToString(runId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsDeleteWorkflowRun: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsDeleteWorkflowRun: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Delete workflow run logs Deletes all logs for a workflow run. You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;actions:write&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="runId">The unique identifier of the workflow run.</param>
        /// <returns></returns>
        public void ActionsDeleteWorkflowRunLogs (string owner, string repo, int? runId)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActionsDeleteWorkflowRunLogs");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActionsDeleteWorkflowRunLogs");
            
            // verify the required parameter 'runId' is set
            if (runId == null) throw new ApiException(400, "Missing required parameter 'runId' when calling ActionsDeleteWorkflowRunLogs");
            

            var path = "/repos/{owner}/{repo}/actions/runs/{run_id}/logs";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "run_id" + "}", ApiClient.ParameterToString(runId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsDeleteWorkflowRunLogs: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsDeleteWorkflowRunLogs: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Disable a selected repository for GitHub Actions in an organization Removes a repository from the list of selected repositories that are enabled for GitHub Actions in an organization. To use this endpoint, the organization permission policy for &#x60;enabled_repositories&#x60; must be configured to &#x60;selected&#x60;. For more information, see \&quot;[Set GitHub Actions permissions for an organization](#set-github-actions-permissions-for-an-organization).\&quot;  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;administration&#x60; organization permission to use this API.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="repositoryId">The unique identifier of the repository.</param>
        /// <returns></returns>
        public void ActionsDisableSelectedRepositoryGithubActionsOrganization (string org, int? repositoryId)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling ActionsDisableSelectedRepositoryGithubActionsOrganization");
            
            // verify the required parameter 'repositoryId' is set
            if (repositoryId == null) throw new ApiException(400, "Missing required parameter 'repositoryId' when calling ActionsDisableSelectedRepositoryGithubActionsOrganization");
            

            var path = "/orgs/{org}/actions/permissions/repositories/{repository_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsDisableSelectedRepositoryGithubActionsOrganization: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsDisableSelectedRepositoryGithubActionsOrganization: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Disable a workflow Disables a workflow and sets the &#x60;state&#x60; of the workflow to &#x60;disabled_manually&#x60;. You can replace &#x60;workflow_id&#x60; with the workflow file name. For example, you could use &#x60;main.yaml&#x60;.  You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;actions:write&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="workflowId">The ID of the workflow. You can also pass the workflow file name as a string.</param>
        /// <returns></returns>
        public void ActionsDisableWorkflow (string owner, string repo, ActionsGetWorkflowWorkflowIdParameter workflowId)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActionsDisableWorkflow");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActionsDisableWorkflow");
            
            // verify the required parameter 'workflowId' is set
            if (workflowId == null) throw new ApiException(400, "Missing required parameter 'workflowId' when calling ActionsDisableWorkflow");
            

            var path = "/repos/{owner}/{repo}/actions/workflows/{workflow_id}/disable";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "workflow_id" + "}", ApiClient.ParameterToString(workflowId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsDisableWorkflow: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsDisableWorkflow: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Download an artifact Gets a redirect URL to download an archive for a repository. This URL expires after 1 minute. Look for &#x60;Location:&#x60; in the response header to find the URL for the download. The &#x60;:archive_format&#x60; must be &#x60;zip&#x60;. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the &#x60;repo&#x60; scope. GitHub Apps must have the &#x60;actions:read&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="artifactId">The unique identifier of the artifact.</param>
        /// <param name="archiveFormat"></param>
        /// <returns></returns>
        public void ActionsDownloadArtifact (string owner, string repo, int? artifactId, string archiveFormat)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActionsDownloadArtifact");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActionsDownloadArtifact");
            
            // verify the required parameter 'artifactId' is set
            if (artifactId == null) throw new ApiException(400, "Missing required parameter 'artifactId' when calling ActionsDownloadArtifact");
            
            // verify the required parameter 'archiveFormat' is set
            if (archiveFormat == null) throw new ApiException(400, "Missing required parameter 'archiveFormat' when calling ActionsDownloadArtifact");
            

            var path = "/repos/{owner}/{repo}/actions/artifacts/{artifact_id}/{archive_format}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "artifact_id" + "}", ApiClient.ParameterToString(artifactId));
path = path.Replace("{" + "archive_format" + "}", ApiClient.ParameterToString(archiveFormat));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsDownloadArtifact: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsDownloadArtifact: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Download job logs for a workflow run Gets a redirect URL to download a plain text file of logs for a workflow job. This link expires after 1 minute. Look for &#x60;Location:&#x60; in the response header to find the URL for the download. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the &#x60;repo&#x60; scope. GitHub Apps must have the &#x60;actions:read&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="jobId">The unique identifier of the job.</param>
        /// <returns></returns>
        public void ActionsDownloadJobLogsForWorkflowRun (string owner, string repo, int? jobId)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActionsDownloadJobLogsForWorkflowRun");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActionsDownloadJobLogsForWorkflowRun");
            
            // verify the required parameter 'jobId' is set
            if (jobId == null) throw new ApiException(400, "Missing required parameter 'jobId' when calling ActionsDownloadJobLogsForWorkflowRun");
            

            var path = "/repos/{owner}/{repo}/actions/jobs/{job_id}/logs";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "job_id" + "}", ApiClient.ParameterToString(jobId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsDownloadJobLogsForWorkflowRun: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsDownloadJobLogsForWorkflowRun: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Download workflow run attempt logs Gets a redirect URL to download an archive of log files for a specific workflow run attempt. This link expires after 1 minute. Look for &#x60;Location:&#x60; in the response header to find the URL for the download. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the &#x60;repo&#x60; scope. GitHub Apps must have the &#x60;actions:read&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="runId">The unique identifier of the workflow run.</param>
        /// <param name="attemptNumber">The attempt number of the workflow run.</param>
        /// <returns></returns>
        public void ActionsDownloadWorkflowRunAttemptLogs (string owner, string repo, int? runId, int? attemptNumber)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActionsDownloadWorkflowRunAttemptLogs");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActionsDownloadWorkflowRunAttemptLogs");
            
            // verify the required parameter 'runId' is set
            if (runId == null) throw new ApiException(400, "Missing required parameter 'runId' when calling ActionsDownloadWorkflowRunAttemptLogs");
            
            // verify the required parameter 'attemptNumber' is set
            if (attemptNumber == null) throw new ApiException(400, "Missing required parameter 'attemptNumber' when calling ActionsDownloadWorkflowRunAttemptLogs");
            

            var path = "/repos/{owner}/{repo}/actions/runs/{run_id}/attempts/{attempt_number}/logs";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "run_id" + "}", ApiClient.ParameterToString(runId));
path = path.Replace("{" + "attempt_number" + "}", ApiClient.ParameterToString(attemptNumber));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsDownloadWorkflowRunAttemptLogs: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsDownloadWorkflowRunAttemptLogs: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Download workflow run logs Gets a redirect URL to download an archive of log files for a workflow run. This link expires after 1 minute. Look for &#x60;Location:&#x60; in the response header to find the URL for the download. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the &#x60;repo&#x60; scope. GitHub Apps must have the &#x60;actions:read&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="runId">The unique identifier of the workflow run.</param>
        /// <returns></returns>
        public void ActionsDownloadWorkflowRunLogs (string owner, string repo, int? runId)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActionsDownloadWorkflowRunLogs");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActionsDownloadWorkflowRunLogs");
            
            // verify the required parameter 'runId' is set
            if (runId == null) throw new ApiException(400, "Missing required parameter 'runId' when calling ActionsDownloadWorkflowRunLogs");
            

            var path = "/repos/{owner}/{repo}/actions/runs/{run_id}/logs";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "run_id" + "}", ApiClient.ParameterToString(runId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsDownloadWorkflowRunLogs: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsDownloadWorkflowRunLogs: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Enable a selected repository for GitHub Actions in an organization Adds a repository to the list of selected repositories that are enabled for GitHub Actions in an organization. To use this endpoint, the organization permission policy for &#x60;enabled_repositories&#x60; must be must be configured to &#x60;selected&#x60;. For more information, see \&quot;[Set GitHub Actions permissions for an organization](#set-github-actions-permissions-for-an-organization).\&quot;  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;administration&#x60; organization permission to use this API.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="repositoryId">The unique identifier of the repository.</param>
        /// <returns></returns>
        public void ActionsEnableSelectedRepositoryGithubActionsOrganization (string org, int? repositoryId)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling ActionsEnableSelectedRepositoryGithubActionsOrganization");
            
            // verify the required parameter 'repositoryId' is set
            if (repositoryId == null) throw new ApiException(400, "Missing required parameter 'repositoryId' when calling ActionsEnableSelectedRepositoryGithubActionsOrganization");
            

            var path = "/orgs/{org}/actions/permissions/repositories/{repository_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsEnableSelectedRepositoryGithubActionsOrganization: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsEnableSelectedRepositoryGithubActionsOrganization: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Enable a workflow Enables a workflow and sets the &#x60;state&#x60; of the workflow to &#x60;active&#x60;. You can replace &#x60;workflow_id&#x60; with the workflow file name. For example, you could use &#x60;main.yaml&#x60;.  You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;actions:write&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="workflowId">The ID of the workflow. You can also pass the workflow file name as a string.</param>
        /// <returns></returns>
        public void ActionsEnableWorkflow (string owner, string repo, ActionsGetWorkflowWorkflowIdParameter workflowId)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActionsEnableWorkflow");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActionsEnableWorkflow");
            
            // verify the required parameter 'workflowId' is set
            if (workflowId == null) throw new ApiException(400, "Missing required parameter 'workflowId' when calling ActionsEnableWorkflow");
            

            var path = "/repos/{owner}/{repo}/actions/workflows/{workflow_id}/enable";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "workflow_id" + "}", ApiClient.ParameterToString(workflowId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsEnableWorkflow: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsEnableWorkflow: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// List GitHub Actions caches for a repository Lists the GitHub Actions caches for a repository. You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;actions:read&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <param name="_ref">The Git reference for the results you want to list. The &#x60;ref&#x60; for a branch can be formatted either as &#x60;refs/heads/&lt;branch name&gt;&#x60; or simply &#x60;&lt;branch name&gt;&#x60;. To reference a pull request use &#x60;refs/pull/&lt;number&gt;/merge&#x60;.</param>
        /// <param name="key">An explicit key or prefix for identifying the cache</param>
        /// <param name="sort">The property to sort the results by. &#x60;created_at&#x60; means when the cache was created. &#x60;last_accessed_at&#x60; means when the cache was last accessed. &#x60;size_in_bytes&#x60; is the size of the cache in bytes.</param>
        /// <param name="direction">The direction to sort the results by.</param>
        /// <returns>RepositoryActionsCaches</returns>
        public RepositoryActionsCaches ActionsGetActionsCacheList (string owner, string repo, int? perPage, int? page, string _ref, string key, string sort, string direction)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActionsGetActionsCacheList");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActionsGetActionsCacheList");
            

            var path = "/repos/{owner}/{repo}/actions/caches";
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
 if (_ref != null) queryParams.Add("ref", ApiClient.ParameterToString(_ref)); // query parameter
 if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
 if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
 if (direction != null) queryParams.Add("direction", ApiClient.ParameterToString(direction)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsGetActionsCacheList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsGetActionsCacheList: " + response.ErrorMessage, response.ErrorMessage);

            return (RepositoryActionsCaches) ApiClient.Deserialize(response.Content, typeof(RepositoryActionsCaches), response.Headers);
        }

        /// <summary>
        /// Get GitHub Actions cache usage for a repository Gets GitHub Actions cache usage for a repository. The data fetched using this API is refreshed approximately every 5 minutes, so values returned from this endpoint may take at least 5 minutes to get updated. Anyone with read access to the repository can use this endpoint. If the repository is private, you must use an access token with the &#x60;repo&#x60; scope. GitHub Apps must have the &#x60;actions:read&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>ActionsCacheUsageByRepository</returns>
        public ActionsCacheUsageByRepository ActionsGetActionsCacheUsage (string owner, string repo)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActionsGetActionsCacheUsage");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActionsGetActionsCacheUsage");
            

            var path = "/repos/{owner}/{repo}/actions/cache/usage";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsGetActionsCacheUsage: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsGetActionsCacheUsage: " + response.ErrorMessage, response.ErrorMessage);

            return (ActionsCacheUsageByRepository) ApiClient.Deserialize(response.Content, typeof(ActionsCacheUsageByRepository), response.Headers);
        }

        /// <summary>
        /// List repositories with GitHub Actions cache usage for an organization Lists repositories and their GitHub Actions cache usage for an organization. The data fetched using this API is refreshed approximately every 5 minutes, so values returned from this endpoint may take at least 5 minutes to get updated. You must authenticate using an access token with the &#x60;read:org&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;organization_admistration:read&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>ActionsGetActionsCacheUsageByRepoForOrg200Response</returns>
        public ActionsGetActionsCacheUsageByRepoForOrg200Response ActionsGetActionsCacheUsageByRepoForOrg (string org, int? perPage, int? page)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling ActionsGetActionsCacheUsageByRepoForOrg");
            

            var path = "/orgs/{org}/actions/cache/usage-by-repository";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsGetActionsCacheUsageByRepoForOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsGetActionsCacheUsageByRepoForOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (ActionsGetActionsCacheUsageByRepoForOrg200Response) ApiClient.Deserialize(response.Content, typeof(ActionsGetActionsCacheUsageByRepoForOrg200Response), response.Headers);
        }

        /// <summary>
        /// Get GitHub Actions cache usage for an enterprise Gets the total GitHub Actions cache usage for an enterprise. The data fetched using this API is refreshed approximately every 5 minutes, so values returned from this endpoint may take at least 5 minutes to get updated. You must authenticate using an access token with the &#x60;admin:enterprise&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <returns>ActionsGetActionsCacheUsageForEnterprise200Response</returns>
        public ActionsGetActionsCacheUsageForEnterprise200Response ActionsGetActionsCacheUsageForEnterprise (string enterprise)
        {
            
            // verify the required parameter 'enterprise' is set
            if (enterprise == null) throw new ApiException(400, "Missing required parameter 'enterprise' when calling ActionsGetActionsCacheUsageForEnterprise");
            

            var path = "/enterprises/{enterprise}/actions/cache/usage";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "enterprise" + "}", ApiClient.ParameterToString(enterprise));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsGetActionsCacheUsageForEnterprise: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsGetActionsCacheUsageForEnterprise: " + response.ErrorMessage, response.ErrorMessage);

            return (ActionsGetActionsCacheUsageForEnterprise200Response) ApiClient.Deserialize(response.Content, typeof(ActionsGetActionsCacheUsageForEnterprise200Response), response.Headers);
        }

        /// <summary>
        /// Get GitHub Actions cache usage for an organization Gets the total GitHub Actions cache usage for an organization. The data fetched using this API is refreshed approximately every 5 minutes, so values returned from this endpoint may take at least 5 minutes to get updated. You must authenticate using an access token with the &#x60;read:org&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;organization_admistration:read&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <returns>ActionsGetActionsCacheUsageForEnterprise200Response</returns>
        public ActionsGetActionsCacheUsageForEnterprise200Response ActionsGetActionsCacheUsageForOrg (string org)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling ActionsGetActionsCacheUsageForOrg");
            

            var path = "/orgs/{org}/actions/cache/usage";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsGetActionsCacheUsageForOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsGetActionsCacheUsageForOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (ActionsGetActionsCacheUsageForEnterprise200Response) ApiClient.Deserialize(response.Content, typeof(ActionsGetActionsCacheUsageForEnterprise200Response), response.Headers);
        }

        /// <summary>
        /// Get allowed actions and reusable workflows for an organization Gets the selected actions and reusable workflows that are allowed in an organization. To use this endpoint, the organization permission policy for &#x60;allowed_actions&#x60; must be configured to &#x60;selected&#x60;. For more information, see \&quot;[Set GitHub Actions permissions for an organization](#set-github-actions-permissions-for-an-organization).\&quot;\&quot;  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;administration&#x60; organization permission to use this API.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <returns>EnterpriseAdminGetAllowedActionsEnterprise200Response</returns>
        public EnterpriseAdminGetAllowedActionsEnterprise200Response ActionsGetAllowedActionsOrganization (string org)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling ActionsGetAllowedActionsOrganization");
            

            var path = "/orgs/{org}/actions/permissions/selected-actions";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsGetAllowedActionsOrganization: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsGetAllowedActionsOrganization: " + response.ErrorMessage, response.ErrorMessage);

            return (EnterpriseAdminGetAllowedActionsEnterprise200Response) ApiClient.Deserialize(response.Content, typeof(EnterpriseAdminGetAllowedActionsEnterprise200Response), response.Headers);
        }

        /// <summary>
        /// Get allowed actions and reusable workflows for a repository Gets the settings for selected actions and reusable workflows that are allowed in a repository. To use this endpoint, the repository policy for &#x60;allowed_actions&#x60; must be configured to &#x60;selected&#x60;. For more information, see \&quot;[Set GitHub Actions permissions for a repository](#set-github-actions-permissions-for-a-repository).\&quot;  You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;administration&#x60; repository permission to use this API.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>EnterpriseAdminGetAllowedActionsEnterprise200Response</returns>
        public EnterpriseAdminGetAllowedActionsEnterprise200Response ActionsGetAllowedActionsRepository (string owner, string repo)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActionsGetAllowedActionsRepository");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActionsGetAllowedActionsRepository");
            

            var path = "/repos/{owner}/{repo}/actions/permissions/selected-actions";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsGetAllowedActionsRepository: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsGetAllowedActionsRepository: " + response.ErrorMessage, response.ErrorMessage);

            return (EnterpriseAdminGetAllowedActionsEnterprise200Response) ApiClient.Deserialize(response.Content, typeof(EnterpriseAdminGetAllowedActionsEnterprise200Response), response.Headers);
        }

        /// <summary>
        /// Get an artifact Gets a specific artifact for a workflow run. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the &#x60;repo&#x60; scope. GitHub Apps must have the &#x60;actions:read&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="artifactId">The unique identifier of the artifact.</param>
        /// <returns>Artifact</returns>
        public Artifact ActionsGetArtifact (string owner, string repo, int? artifactId)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActionsGetArtifact");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActionsGetArtifact");
            
            // verify the required parameter 'artifactId' is set
            if (artifactId == null) throw new ApiException(400, "Missing required parameter 'artifactId' when calling ActionsGetArtifact");
            

            var path = "/repos/{owner}/{repo}/actions/artifacts/{artifact_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "artifact_id" + "}", ApiClient.ParameterToString(artifactId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsGetArtifact: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsGetArtifact: " + response.ErrorMessage, response.ErrorMessage);

            return (Artifact) ApiClient.Deserialize(response.Content, typeof(Artifact), response.Headers);
        }

        /// <summary>
        /// Get the opt-out flag of an OIDC subject claim customization for a repository Gets the &#x60;opt-out&#x60; flag of a GitHub Actions OpenID Connect (OIDC) subject claim customization for a repository. You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;organization_administration:read&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>TheJsonPayloadEnablesDisablesTheUseOfSubClaimCustomization</returns>
        public TheJsonPayloadEnablesDisablesTheUseOfSubClaimCustomization ActionsGetCustomOidcSubClaimForRepo (string owner, string repo)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActionsGetCustomOidcSubClaimForRepo");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActionsGetCustomOidcSubClaimForRepo");
            

            var path = "/repos/{owner}/{repo}/actions/oidc/customization/sub";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsGetCustomOidcSubClaimForRepo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsGetCustomOidcSubClaimForRepo: " + response.ErrorMessage, response.ErrorMessage);

            return (TheJsonPayloadEnablesDisablesTheUseOfSubClaimCustomization) ApiClient.Deserialize(response.Content, typeof(TheJsonPayloadEnablesDisablesTheUseOfSubClaimCustomization), response.Headers);
        }

        /// <summary>
        /// Get an environment public key Get the public key for an environment, which you need to encrypt environment secrets. You need to encrypt a secret before you can create or update secrets. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the &#x60;repo&#x60; scope. GitHub Apps must have the &#x60;secrets&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="repositoryId">The unique identifier of the repository.</param>
        /// <param name="environmentName">The name of the environment</param>
        /// <returns>ActionsPublicKey</returns>
        public ActionsPublicKey ActionsGetEnvironmentPublicKey (int? repositoryId, string environmentName)
        {
            
            // verify the required parameter 'repositoryId' is set
            if (repositoryId == null) throw new ApiException(400, "Missing required parameter 'repositoryId' when calling ActionsGetEnvironmentPublicKey");
            
            // verify the required parameter 'environmentName' is set
            if (environmentName == null) throw new ApiException(400, "Missing required parameter 'environmentName' when calling ActionsGetEnvironmentPublicKey");
            

            var path = "/repositories/{repository_id}/environments/{environment_name}/secrets/public-key";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "repository_id" + "}", ApiClient.ParameterToString(repositoryId));
path = path.Replace("{" + "environment_name" + "}", ApiClient.ParameterToString(environmentName));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsGetEnvironmentPublicKey: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsGetEnvironmentPublicKey: " + response.ErrorMessage, response.ErrorMessage);

            return (ActionsPublicKey) ApiClient.Deserialize(response.Content, typeof(ActionsPublicKey), response.Headers);
        }

        /// <summary>
        /// Get an environment secret Gets a single environment secret without revealing its encrypted value. You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;secrets&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="repositoryId">The unique identifier of the repository.</param>
        /// <param name="environmentName">The name of the environment</param>
        /// <param name="secretName">The name of the secret.</param>
        /// <returns>ActionsSecret</returns>
        public ActionsSecret ActionsGetEnvironmentSecret (int? repositoryId, string environmentName, string secretName)
        {
            
            // verify the required parameter 'repositoryId' is set
            if (repositoryId == null) throw new ApiException(400, "Missing required parameter 'repositoryId' when calling ActionsGetEnvironmentSecret");
            
            // verify the required parameter 'environmentName' is set
            if (environmentName == null) throw new ApiException(400, "Missing required parameter 'environmentName' when calling ActionsGetEnvironmentSecret");
            
            // verify the required parameter 'secretName' is set
            if (secretName == null) throw new ApiException(400, "Missing required parameter 'secretName' when calling ActionsGetEnvironmentSecret");
            

            var path = "/repositories/{repository_id}/environments/{environment_name}/secrets/{secret_name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "repository_id" + "}", ApiClient.ParameterToString(repositoryId));
path = path.Replace("{" + "environment_name" + "}", ApiClient.ParameterToString(environmentName));
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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsGetEnvironmentSecret: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsGetEnvironmentSecret: " + response.ErrorMessage, response.ErrorMessage);

            return (ActionsSecret) ApiClient.Deserialize(response.Content, typeof(ActionsSecret), response.Headers);
        }

        /// <summary>
        /// Get default workflow permissions for an enterprise Gets the default workflow permissions granted to the &#x60;GITHUB_TOKEN&#x60; when running workflows in an enterprise, as well as whether GitHub Actions can submit approving pull request reviews. For more information, see \&quot;[Enforcing a policy for workflow permissions in your enterprise](https://docs.github.com/enterprise-cloud@latest/admin/policies/enforcing-policies-for-your-enterprise/enforcing-policies-for-github-actions-in-your-enterprise#enforcing-a-policy-for-workflow-permissions-in-your-enterprise).\&quot;  You must authenticate using an access token with the &#x60;admin:enterprise&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;enterprise_administration:write&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <returns>ActionsGetGithubActionsDefaultWorkflowPermissionsEnterprise200Response</returns>
        public ActionsGetGithubActionsDefaultWorkflowPermissionsEnterprise200Response ActionsGetGithubActionsDefaultWorkflowPermissionsEnterprise (string enterprise)
        {
            
            // verify the required parameter 'enterprise' is set
            if (enterprise == null) throw new ApiException(400, "Missing required parameter 'enterprise' when calling ActionsGetGithubActionsDefaultWorkflowPermissionsEnterprise");
            

            var path = "/enterprises/{enterprise}/actions/permissions/workflow";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "enterprise" + "}", ApiClient.ParameterToString(enterprise));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsGetGithubActionsDefaultWorkflowPermissionsEnterprise: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsGetGithubActionsDefaultWorkflowPermissionsEnterprise: " + response.ErrorMessage, response.ErrorMessage);

            return (ActionsGetGithubActionsDefaultWorkflowPermissionsEnterprise200Response) ApiClient.Deserialize(response.Content, typeof(ActionsGetGithubActionsDefaultWorkflowPermissionsEnterprise200Response), response.Headers);
        }

        /// <summary>
        /// Get default workflow permissions for an organization Gets the default workflow permissions granted to the &#x60;GITHUB_TOKEN&#x60; when running workflows in an organization, as well as whether GitHub Actions can submit approving pull request reviews. For more information, see \&quot;[Setting the permissions of the GITHUB_TOKEN for your organization](https://docs.github.com/organizations/managing-organization-settings/disabling-or-limiting-github-actions-for-your-organization#setting-the-permissions-of-the-github_token-for-your-organization).\&quot;  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;administration&#x60; organization permission to use this API.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <returns>ActionsGetGithubActionsDefaultWorkflowPermissionsEnterprise200Response</returns>
        public ActionsGetGithubActionsDefaultWorkflowPermissionsEnterprise200Response ActionsGetGithubActionsDefaultWorkflowPermissionsOrganization (string org)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling ActionsGetGithubActionsDefaultWorkflowPermissionsOrganization");
            

            var path = "/orgs/{org}/actions/permissions/workflow";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsGetGithubActionsDefaultWorkflowPermissionsOrganization: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsGetGithubActionsDefaultWorkflowPermissionsOrganization: " + response.ErrorMessage, response.ErrorMessage);

            return (ActionsGetGithubActionsDefaultWorkflowPermissionsEnterprise200Response) ApiClient.Deserialize(response.Content, typeof(ActionsGetGithubActionsDefaultWorkflowPermissionsEnterprise200Response), response.Headers);
        }

        /// <summary>
        /// Get default workflow permissions for a repository Gets the default workflow permissions granted to the &#x60;GITHUB_TOKEN&#x60; when running workflows in a repository, as well as if GitHub Actions can submit approving pull request reviews. For more information, see \&quot;[Setting the permissions of the GITHUB_TOKEN for your repository](https://docs.github.com/repositories/managing-your-repositorys-settings-and-features/enabling-features-for-your-repository/managing-github-actions-settings-for-a-repository#setting-the-permissions-of-the-github_token-for-your-repository).\&quot;  You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the repository &#x60;administration&#x60; permission to use this API.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>ActionsGetGithubActionsDefaultWorkflowPermissionsEnterprise200Response</returns>
        public ActionsGetGithubActionsDefaultWorkflowPermissionsEnterprise200Response ActionsGetGithubActionsDefaultWorkflowPermissionsRepository (string owner, string repo)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActionsGetGithubActionsDefaultWorkflowPermissionsRepository");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActionsGetGithubActionsDefaultWorkflowPermissionsRepository");
            

            var path = "/repos/{owner}/{repo}/actions/permissions/workflow";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsGetGithubActionsDefaultWorkflowPermissionsRepository: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsGetGithubActionsDefaultWorkflowPermissionsRepository: " + response.ErrorMessage, response.ErrorMessage);

            return (ActionsGetGithubActionsDefaultWorkflowPermissionsEnterprise200Response) ApiClient.Deserialize(response.Content, typeof(ActionsGetGithubActionsDefaultWorkflowPermissionsEnterprise200Response), response.Headers);
        }

        /// <summary>
        /// Get GitHub Actions permissions for an organization Gets the GitHub Actions permissions policy for repositories and allowed actions and reusable workflows in an organization.  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;administration&#x60; organization permission to use this API.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <returns>ActionsGetGithubActionsPermissionsOrganization200Response</returns>
        public ActionsGetGithubActionsPermissionsOrganization200Response ActionsGetGithubActionsPermissionsOrganization (string org)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling ActionsGetGithubActionsPermissionsOrganization");
            

            var path = "/orgs/{org}/actions/permissions";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsGetGithubActionsPermissionsOrganization: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsGetGithubActionsPermissionsOrganization: " + response.ErrorMessage, response.ErrorMessage);

            return (ActionsGetGithubActionsPermissionsOrganization200Response) ApiClient.Deserialize(response.Content, typeof(ActionsGetGithubActionsPermissionsOrganization200Response), response.Headers);
        }

        /// <summary>
        /// Get GitHub Actions permissions for a repository Gets the GitHub Actions permissions policy for a repository, including whether GitHub Actions is enabled and the actions and reusable workflows allowed to run in the repository.  You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;administration&#x60; repository permission to use this API.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>ActionsGetGithubActionsPermissionsRepository200Response</returns>
        public ActionsGetGithubActionsPermissionsRepository200Response ActionsGetGithubActionsPermissionsRepository (string owner, string repo)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActionsGetGithubActionsPermissionsRepository");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActionsGetGithubActionsPermissionsRepository");
            

            var path = "/repos/{owner}/{repo}/actions/permissions";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsGetGithubActionsPermissionsRepository: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsGetGithubActionsPermissionsRepository: " + response.ErrorMessage, response.ErrorMessage);

            return (ActionsGetGithubActionsPermissionsRepository200Response) ApiClient.Deserialize(response.Content, typeof(ActionsGetGithubActionsPermissionsRepository200Response), response.Headers);
        }

        /// <summary>
        /// Get a job for a workflow run Gets a specific job in a workflow run. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the &#x60;repo&#x60; scope. GitHub Apps must have the &#x60;actions:read&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="jobId">The unique identifier of the job.</param>
        /// <returns>Job</returns>
        public Job ActionsGetJobForWorkflowRun (string owner, string repo, int? jobId)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActionsGetJobForWorkflowRun");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActionsGetJobForWorkflowRun");
            
            // verify the required parameter 'jobId' is set
            if (jobId == null) throw new ApiException(400, "Missing required parameter 'jobId' when calling ActionsGetJobForWorkflowRun");
            

            var path = "/repos/{owner}/{repo}/actions/jobs/{job_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "job_id" + "}", ApiClient.ParameterToString(jobId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsGetJobForWorkflowRun: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsGetJobForWorkflowRun: " + response.ErrorMessage, response.ErrorMessage);

            return (Job) ApiClient.Deserialize(response.Content, typeof(Job), response.Headers);
        }

        /// <summary>
        /// Get an organization public key Gets your public key, which you need to encrypt secrets. You need to encrypt a secret before you can create or update secrets. You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;secrets&#x60; organization permission to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <returns>ActionsPublicKey</returns>
        public ActionsPublicKey ActionsGetOrgPublicKey (string org)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling ActionsGetOrgPublicKey");
            

            var path = "/orgs/{org}/actions/secrets/public-key";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsGetOrgPublicKey: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsGetOrgPublicKey: " + response.ErrorMessage, response.ErrorMessage);

            return (ActionsPublicKey) ApiClient.Deserialize(response.Content, typeof(ActionsPublicKey), response.Headers);
        }

        /// <summary>
        /// Get an organization secret Gets a single organization secret without revealing its encrypted value. You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;secrets&#x60; organization permission to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="secretName">The name of the secret.</param>
        /// <returns>ActionsSecretForAnOrganization</returns>
        public ActionsSecretForAnOrganization ActionsGetOrgSecret (string org, string secretName)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling ActionsGetOrgSecret");
            
            // verify the required parameter 'secretName' is set
            if (secretName == null) throw new ApiException(400, "Missing required parameter 'secretName' when calling ActionsGetOrgSecret");
            

            var path = "/orgs/{org}/actions/secrets/{secret_name}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsGetOrgSecret: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsGetOrgSecret: " + response.ErrorMessage, response.ErrorMessage);

            return (ActionsSecretForAnOrganization) ApiClient.Deserialize(response.Content, typeof(ActionsSecretForAnOrganization), response.Headers);
        }

        /// <summary>
        /// Get pending deployments for a workflow run Get all deployment environments for a workflow run that are waiting for protection rules to pass.  Anyone with read access to the repository can use this endpoint. If the repository is private, you must use an access token with the &#x60;repo&#x60; scope. GitHub Apps must have the &#x60;actions:read&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="runId">The unique identifier of the workflow run.</param>
        /// <returns>List&lt;PendingDeployment&gt;</returns>
        public List<PendingDeployment> ActionsGetPendingDeploymentsForRun (string owner, string repo, int? runId)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActionsGetPendingDeploymentsForRun");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActionsGetPendingDeploymentsForRun");
            
            // verify the required parameter 'runId' is set
            if (runId == null) throw new ApiException(400, "Missing required parameter 'runId' when calling ActionsGetPendingDeploymentsForRun");
            

            var path = "/repos/{owner}/{repo}/actions/runs/{run_id}/pending_deployments";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "run_id" + "}", ApiClient.ParameterToString(runId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsGetPendingDeploymentsForRun: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsGetPendingDeploymentsForRun: " + response.ErrorMessage, response.ErrorMessage);

            return (List<PendingDeployment>) ApiClient.Deserialize(response.Content, typeof(List<PendingDeployment>), response.Headers);
        }

        /// <summary>
        /// Get a repository public key Gets your public key, which you need to encrypt secrets. You need to encrypt a secret before you can create or update secrets. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the &#x60;repo&#x60; scope. GitHub Apps must have the &#x60;secrets&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>ActionsPublicKey</returns>
        public ActionsPublicKey ActionsGetRepoPublicKey (string owner, string repo)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActionsGetRepoPublicKey");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActionsGetRepoPublicKey");
            

            var path = "/repos/{owner}/{repo}/actions/secrets/public-key";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsGetRepoPublicKey: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsGetRepoPublicKey: " + response.ErrorMessage, response.ErrorMessage);

            return (ActionsPublicKey) ApiClient.Deserialize(response.Content, typeof(ActionsPublicKey), response.Headers);
        }

        /// <summary>
        /// Get a repository secret Gets a single repository secret without revealing its encrypted value. You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;secrets&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="secretName">The name of the secret.</param>
        /// <returns>ActionsSecret</returns>
        public ActionsSecret ActionsGetRepoSecret (string owner, string repo, string secretName)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActionsGetRepoSecret");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActionsGetRepoSecret");
            
            // verify the required parameter 'secretName' is set
            if (secretName == null) throw new ApiException(400, "Missing required parameter 'secretName' when calling ActionsGetRepoSecret");
            

            var path = "/repos/{owner}/{repo}/actions/secrets/{secret_name}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsGetRepoSecret: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsGetRepoSecret: " + response.ErrorMessage, response.ErrorMessage);

            return (ActionsSecret) ApiClient.Deserialize(response.Content, typeof(ActionsSecret), response.Headers);
        }

        /// <summary>
        /// Get the review history for a workflow run Anyone with read access to the repository can use this endpoint. If the repository is private, you must use an access token with the &#x60;repo&#x60; scope. GitHub Apps must have the &#x60;actions:read&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="runId">The unique identifier of the workflow run.</param>
        /// <returns>List&lt;EnvironmentApproval&gt;</returns>
        public List<EnvironmentApproval> ActionsGetReviewsForRun (string owner, string repo, int? runId)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActionsGetReviewsForRun");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActionsGetReviewsForRun");
            
            // verify the required parameter 'runId' is set
            if (runId == null) throw new ApiException(400, "Missing required parameter 'runId' when calling ActionsGetReviewsForRun");
            

            var path = "/repos/{owner}/{repo}/actions/runs/{run_id}/approvals";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "run_id" + "}", ApiClient.ParameterToString(runId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsGetReviewsForRun: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsGetReviewsForRun: " + response.ErrorMessage, response.ErrorMessage);

            return (List<EnvironmentApproval>) ApiClient.Deserialize(response.Content, typeof(List<EnvironmentApproval>), response.Headers);
        }

        /// <summary>
        /// Get a self-hosted runner for an organization Gets a specific self-hosted runner configured in an organization.  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="runnerId">Unique identifier of the self-hosted runner.</param>
        /// <returns>SelfHostedRunners</returns>
        public SelfHostedRunners ActionsGetSelfHostedRunnerForOrg (string org, int? runnerId)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling ActionsGetSelfHostedRunnerForOrg");
            
            // verify the required parameter 'runnerId' is set
            if (runnerId == null) throw new ApiException(400, "Missing required parameter 'runnerId' when calling ActionsGetSelfHostedRunnerForOrg");
            

            var path = "/orgs/{org}/actions/runners/{runner_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "runner_id" + "}", ApiClient.ParameterToString(runnerId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsGetSelfHostedRunnerForOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsGetSelfHostedRunnerForOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (SelfHostedRunners) ApiClient.Deserialize(response.Content, typeof(SelfHostedRunners), response.Headers);
        }

        /// <summary>
        /// Get a self-hosted runner for a repository Gets a specific self-hosted runner configured in a repository.  You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="runnerId">Unique identifier of the self-hosted runner.</param>
        /// <returns>SelfHostedRunners</returns>
        public SelfHostedRunners ActionsGetSelfHostedRunnerForRepo (string owner, string repo, int? runnerId)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActionsGetSelfHostedRunnerForRepo");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActionsGetSelfHostedRunnerForRepo");
            
            // verify the required parameter 'runnerId' is set
            if (runnerId == null) throw new ApiException(400, "Missing required parameter 'runnerId' when calling ActionsGetSelfHostedRunnerForRepo");
            

            var path = "/repos/{owner}/{repo}/actions/runners/{runner_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "runner_id" + "}", ApiClient.ParameterToString(runnerId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsGetSelfHostedRunnerForRepo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsGetSelfHostedRunnerForRepo: " + response.ErrorMessage, response.ErrorMessage);

            return (SelfHostedRunners) ApiClient.Deserialize(response.Content, typeof(SelfHostedRunners), response.Headers);
        }

        /// <summary>
        /// Get a self-hosted runner group for an organization The self-hosted runner groups REST API is available with GitHub Enterprise Cloud. For more information, see \&quot;[GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products).\&quot;  Gets a specific self-hosted runner group for an organization.  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="runnerGroupId">Unique identifier of the self-hosted runner group.</param>
        /// <returns>ActionsListSelfHostedRunnerGroupsForOrg200ResponseRunnerGroupsInner</returns>
        public ActionsListSelfHostedRunnerGroupsForOrg200ResponseRunnerGroupsInner ActionsGetSelfHostedRunnerGroupForOrg (string org, int? runnerGroupId)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling ActionsGetSelfHostedRunnerGroupForOrg");
            
            // verify the required parameter 'runnerGroupId' is set
            if (runnerGroupId == null) throw new ApiException(400, "Missing required parameter 'runnerGroupId' when calling ActionsGetSelfHostedRunnerGroupForOrg");
            

            var path = "/orgs/{org}/actions/runner-groups/{runner_group_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "runner_group_id" + "}", ApiClient.ParameterToString(runnerGroupId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsGetSelfHostedRunnerGroupForOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsGetSelfHostedRunnerGroupForOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (ActionsListSelfHostedRunnerGroupsForOrg200ResponseRunnerGroupsInner) ApiClient.Deserialize(response.Content, typeof(ActionsListSelfHostedRunnerGroupsForOrg200ResponseRunnerGroupsInner), response.Headers);
        }

        /// <summary>
        /// Get a workflow Gets a specific workflow. You can replace &#x60;workflow_id&#x60; with the workflow file name. For example, you could use &#x60;main.yaml&#x60;. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the &#x60;repo&#x60; scope. GitHub Apps must have the &#x60;actions:read&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="workflowId">The ID of the workflow. You can also pass the workflow file name as a string.</param>
        /// <returns>Workflow</returns>
        public Workflow ActionsGetWorkflow (string owner, string repo, ActionsGetWorkflowWorkflowIdParameter workflowId)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActionsGetWorkflow");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActionsGetWorkflow");
            
            // verify the required parameter 'workflowId' is set
            if (workflowId == null) throw new ApiException(400, "Missing required parameter 'workflowId' when calling ActionsGetWorkflow");
            

            var path = "/repos/{owner}/{repo}/actions/workflows/{workflow_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "workflow_id" + "}", ApiClient.ParameterToString(workflowId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsGetWorkflow: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsGetWorkflow: " + response.ErrorMessage, response.ErrorMessage);

            return (Workflow) ApiClient.Deserialize(response.Content, typeof(Workflow), response.Headers);
        }

        /// <summary>
        /// Get the level of access for workflows outside of the repository Gets the level of access that workflows outside of the repository have to actions and reusable workflows in the repository. This endpoint only applies to internal repositories. For more information, see \&quot;[Managing GitHub Actions settings for a repository](https://docs.github.com/repositories/managing-your-repositorys-settings-and-features/enabling-features-for-your-repository/managing-github-actions-settings-for-a-repository#allowing-access-to-components-in-an-internal-repository).\&quot;  You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the repository &#x60;administration&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>ActionsGetWorkflowAccessToRepository200Response</returns>
        public ActionsGetWorkflowAccessToRepository200Response ActionsGetWorkflowAccessToRepository (string owner, string repo)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActionsGetWorkflowAccessToRepository");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActionsGetWorkflowAccessToRepository");
            

            var path = "/repos/{owner}/{repo}/actions/permissions/access";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsGetWorkflowAccessToRepository: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsGetWorkflowAccessToRepository: " + response.ErrorMessage, response.ErrorMessage);

            return (ActionsGetWorkflowAccessToRepository200Response) ApiClient.Deserialize(response.Content, typeof(ActionsGetWorkflowAccessToRepository200Response), response.Headers);
        }

        /// <summary>
        /// Get a workflow run Gets a specific workflow run. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the &#x60;repo&#x60; scope. GitHub Apps must have the &#x60;actions:read&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="runId">The unique identifier of the workflow run.</param>
        /// <param name="excludePullRequests">If &#x60;true&#x60; pull requests are omitted from the response (empty array).</param>
        /// <returns>WorkflowRun</returns>
        public WorkflowRun ActionsGetWorkflowRun (string owner, string repo, int? runId, bool? excludePullRequests)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActionsGetWorkflowRun");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActionsGetWorkflowRun");
            
            // verify the required parameter 'runId' is set
            if (runId == null) throw new ApiException(400, "Missing required parameter 'runId' when calling ActionsGetWorkflowRun");
            

            var path = "/repos/{owner}/{repo}/actions/runs/{run_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "run_id" + "}", ApiClient.ParameterToString(runId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (excludePullRequests != null) queryParams.Add("exclude_pull_requests", ApiClient.ParameterToString(excludePullRequests)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsGetWorkflowRun: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsGetWorkflowRun: " + response.ErrorMessage, response.ErrorMessage);

            return (WorkflowRun) ApiClient.Deserialize(response.Content, typeof(WorkflowRun), response.Headers);
        }

        /// <summary>
        /// Get a workflow run attempt Gets a specific workflow run attempt. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the &#x60;repo&#x60; scope. GitHub Apps must have the &#x60;actions:read&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="runId">The unique identifier of the workflow run.</param>
        /// <param name="attemptNumber">The attempt number of the workflow run.</param>
        /// <param name="excludePullRequests">If &#x60;true&#x60; pull requests are omitted from the response (empty array).</param>
        /// <returns>WorkflowRun</returns>
        public WorkflowRun ActionsGetWorkflowRunAttempt (string owner, string repo, int? runId, int? attemptNumber, bool? excludePullRequests)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActionsGetWorkflowRunAttempt");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActionsGetWorkflowRunAttempt");
            
            // verify the required parameter 'runId' is set
            if (runId == null) throw new ApiException(400, "Missing required parameter 'runId' when calling ActionsGetWorkflowRunAttempt");
            
            // verify the required parameter 'attemptNumber' is set
            if (attemptNumber == null) throw new ApiException(400, "Missing required parameter 'attemptNumber' when calling ActionsGetWorkflowRunAttempt");
            

            var path = "/repos/{owner}/{repo}/actions/runs/{run_id}/attempts/{attempt_number}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "run_id" + "}", ApiClient.ParameterToString(runId));
path = path.Replace("{" + "attempt_number" + "}", ApiClient.ParameterToString(attemptNumber));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (excludePullRequests != null) queryParams.Add("exclude_pull_requests", ApiClient.ParameterToString(excludePullRequests)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsGetWorkflowRunAttempt: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsGetWorkflowRunAttempt: " + response.ErrorMessage, response.ErrorMessage);

            return (WorkflowRun) ApiClient.Deserialize(response.Content, typeof(WorkflowRun), response.Headers);
        }

        /// <summary>
        /// Get workflow run usage Gets the number of billable minutes and total run time for a specific workflow run. Billable minutes only apply to workflows in private repositories that use GitHub-hosted runners. Usage is listed for each GitHub-hosted runner operating system in milliseconds. Any job re-runs are also included in the usage. The usage does not include the multiplier for macOS and Windows runners and is not rounded up to the nearest whole minute. For more information, see \&quot;[Managing billing for GitHub Actions](https://docs.github.com/github/setting-up-and-managing-billing-and-payments-on-github/managing-billing-for-github-actions)\&quot;.  Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the &#x60;repo&#x60; scope. GitHub Apps must have the &#x60;actions:read&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="runId">The unique identifier of the workflow run.</param>
        /// <returns>WorkflowRunUsage</returns>
        public WorkflowRunUsage ActionsGetWorkflowRunUsage (string owner, string repo, int? runId)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActionsGetWorkflowRunUsage");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActionsGetWorkflowRunUsage");
            
            // verify the required parameter 'runId' is set
            if (runId == null) throw new ApiException(400, "Missing required parameter 'runId' when calling ActionsGetWorkflowRunUsage");
            

            var path = "/repos/{owner}/{repo}/actions/runs/{run_id}/timing";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "run_id" + "}", ApiClient.ParameterToString(runId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsGetWorkflowRunUsage: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsGetWorkflowRunUsage: " + response.ErrorMessage, response.ErrorMessage);

            return (WorkflowRunUsage) ApiClient.Deserialize(response.Content, typeof(WorkflowRunUsage), response.Headers);
        }

        /// <summary>
        /// Get workflow usage Gets the number of billable minutes used by a specific workflow during the current billing cycle. Billable minutes only apply to workflows in private repositories that use GitHub-hosted runners. Usage is listed for each GitHub-hosted runner operating system in milliseconds. Any job re-runs are also included in the usage. The usage does not include the multiplier for macOS and Windows runners and is not rounded up to the nearest whole minute. For more information, see \&quot;[Managing billing for GitHub Actions](https://docs.github.com/github/setting-up-and-managing-billing-and-payments-on-github/managing-billing-for-github-actions)\&quot;.  You can replace &#x60;workflow_id&#x60; with the workflow file name. For example, you could use &#x60;main.yaml&#x60;. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the &#x60;repo&#x60; scope. GitHub Apps must have the &#x60;actions:read&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="workflowId">The ID of the workflow. You can also pass the workflow file name as a string.</param>
        /// <returns>WorkflowUsage</returns>
        public WorkflowUsage ActionsGetWorkflowUsage (string owner, string repo, ActionsGetWorkflowWorkflowIdParameter workflowId)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActionsGetWorkflowUsage");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActionsGetWorkflowUsage");
            
            // verify the required parameter 'workflowId' is set
            if (workflowId == null) throw new ApiException(400, "Missing required parameter 'workflowId' when calling ActionsGetWorkflowUsage");
            

            var path = "/repos/{owner}/{repo}/actions/workflows/{workflow_id}/timing";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "workflow_id" + "}", ApiClient.ParameterToString(workflowId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsGetWorkflowUsage: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsGetWorkflowUsage: " + response.ErrorMessage, response.ErrorMessage);

            return (WorkflowUsage) ApiClient.Deserialize(response.Content, typeof(WorkflowUsage), response.Headers);
        }

        /// <summary>
        /// List artifacts for a repository Lists all artifacts for a repository. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the &#x60;repo&#x60; scope. GitHub Apps must have the &#x60;actions:read&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>ActionsListArtifactsForRepo200Response</returns>
        public ActionsListArtifactsForRepo200Response ActionsListArtifactsForRepo (string owner, string repo, int? perPage, int? page)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActionsListArtifactsForRepo");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActionsListArtifactsForRepo");
            

            var path = "/repos/{owner}/{repo}/actions/artifacts";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsListArtifactsForRepo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsListArtifactsForRepo: " + response.ErrorMessage, response.ErrorMessage);

            return (ActionsListArtifactsForRepo200Response) ApiClient.Deserialize(response.Content, typeof(ActionsListArtifactsForRepo200Response), response.Headers);
        }

        /// <summary>
        /// List environment secrets Lists all secrets available in an environment without revealing their encrypted values. You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;secrets&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="repositoryId">The unique identifier of the repository.</param>
        /// <param name="environmentName">The name of the environment</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>ActionsListRepoSecrets200Response</returns>
        public ActionsListRepoSecrets200Response ActionsListEnvironmentSecrets (int? repositoryId, string environmentName, int? perPage, int? page)
        {
            
            // verify the required parameter 'repositoryId' is set
            if (repositoryId == null) throw new ApiException(400, "Missing required parameter 'repositoryId' when calling ActionsListEnvironmentSecrets");
            
            // verify the required parameter 'environmentName' is set
            if (environmentName == null) throw new ApiException(400, "Missing required parameter 'environmentName' when calling ActionsListEnvironmentSecrets");
            

            var path = "/repositories/{repository_id}/environments/{environment_name}/secrets";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "repository_id" + "}", ApiClient.ParameterToString(repositoryId));
path = path.Replace("{" + "environment_name" + "}", ApiClient.ParameterToString(environmentName));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsListEnvironmentSecrets: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsListEnvironmentSecrets: " + response.ErrorMessage, response.ErrorMessage);

            return (ActionsListRepoSecrets200Response) ApiClient.Deserialize(response.Content, typeof(ActionsListRepoSecrets200Response), response.Headers);
        }

        /// <summary>
        /// List jobs for a workflow run Lists jobs for a workflow run. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the &#x60;repo&#x60; scope. GitHub Apps must have the &#x60;actions:read&#x60; permission to use this endpoint. You can use parameters to narrow the list of results. For more information about using parameters, see [Parameters](https://docs.github.com/rest/overview/resources-in-the-rest-api#parameters).
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="runId">The unique identifier of the workflow run.</param>
        /// <param name="filter">Filters jobs by their &#x60;completed_at&#x60; timestamp. &#x60;latest&#x60; returns jobs from the most recent execution of the workflow run. &#x60;all&#x60; returns all jobs for a workflow run, including from old executions of the workflow run.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>ActionsListJobsForWorkflowRunAttempt200Response</returns>
        public ActionsListJobsForWorkflowRunAttempt200Response ActionsListJobsForWorkflowRun (string owner, string repo, int? runId, string filter, int? perPage, int? page)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActionsListJobsForWorkflowRun");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActionsListJobsForWorkflowRun");
            
            // verify the required parameter 'runId' is set
            if (runId == null) throw new ApiException(400, "Missing required parameter 'runId' when calling ActionsListJobsForWorkflowRun");
            

            var path = "/repos/{owner}/{repo}/actions/runs/{run_id}/jobs";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "run_id" + "}", ApiClient.ParameterToString(runId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (filter != null) queryParams.Add("filter", ApiClient.ParameterToString(filter)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsListJobsForWorkflowRun: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsListJobsForWorkflowRun: " + response.ErrorMessage, response.ErrorMessage);

            return (ActionsListJobsForWorkflowRunAttempt200Response) ApiClient.Deserialize(response.Content, typeof(ActionsListJobsForWorkflowRunAttempt200Response), response.Headers);
        }

        /// <summary>
        /// List jobs for a workflow run attempt Lists jobs for a specific workflow run attempt. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the &#x60;repo&#x60; scope. GitHub Apps must have the &#x60;actions:read&#x60; permission to use this endpoint. You can use parameters to narrow the list of results. For more information about using parameters, see [Parameters](https://docs.github.com/rest/overview/resources-in-the-rest-api#parameters).
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="runId">The unique identifier of the workflow run.</param>
        /// <param name="attemptNumber">The attempt number of the workflow run.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>ActionsListJobsForWorkflowRunAttempt200Response</returns>
        public ActionsListJobsForWorkflowRunAttempt200Response ActionsListJobsForWorkflowRunAttempt (string owner, string repo, int? runId, int? attemptNumber, int? perPage, int? page)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActionsListJobsForWorkflowRunAttempt");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActionsListJobsForWorkflowRunAttempt");
            
            // verify the required parameter 'runId' is set
            if (runId == null) throw new ApiException(400, "Missing required parameter 'runId' when calling ActionsListJobsForWorkflowRunAttempt");
            
            // verify the required parameter 'attemptNumber' is set
            if (attemptNumber == null) throw new ApiException(400, "Missing required parameter 'attemptNumber' when calling ActionsListJobsForWorkflowRunAttempt");
            

            var path = "/repos/{owner}/{repo}/actions/runs/{run_id}/attempts/{attempt_number}/jobs";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "run_id" + "}", ApiClient.ParameterToString(runId));
path = path.Replace("{" + "attempt_number" + "}", ApiClient.ParameterToString(attemptNumber));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsListJobsForWorkflowRunAttempt: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsListJobsForWorkflowRunAttempt: " + response.ErrorMessage, response.ErrorMessage);

            return (ActionsListJobsForWorkflowRunAttempt200Response) ApiClient.Deserialize(response.Content, typeof(ActionsListJobsForWorkflowRunAttempt200Response), response.Headers);
        }

        /// <summary>
        /// List labels for a self-hosted runner for an organization Lists all labels for a self-hosted runner configured in an organization.  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="runnerId">Unique identifier of the self-hosted runner.</param>
        /// <returns>EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response</returns>
        public EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response ActionsListLabelsForSelfHostedRunnerForOrg (string org, int? runnerId)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling ActionsListLabelsForSelfHostedRunnerForOrg");
            
            // verify the required parameter 'runnerId' is set
            if (runnerId == null) throw new ApiException(400, "Missing required parameter 'runnerId' when calling ActionsListLabelsForSelfHostedRunnerForOrg");
            

            var path = "/orgs/{org}/actions/runners/{runner_id}/labels";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "runner_id" + "}", ApiClient.ParameterToString(runnerId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsListLabelsForSelfHostedRunnerForOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsListLabelsForSelfHostedRunnerForOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response) ApiClient.Deserialize(response.Content, typeof(EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response), response.Headers);
        }

        /// <summary>
        /// List labels for a self-hosted runner for a repository Lists all labels for a self-hosted runner configured in a repository.  You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="runnerId">Unique identifier of the self-hosted runner.</param>
        /// <returns>EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response</returns>
        public EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response ActionsListLabelsForSelfHostedRunnerForRepo (string owner, string repo, int? runnerId)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActionsListLabelsForSelfHostedRunnerForRepo");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActionsListLabelsForSelfHostedRunnerForRepo");
            
            // verify the required parameter 'runnerId' is set
            if (runnerId == null) throw new ApiException(400, "Missing required parameter 'runnerId' when calling ActionsListLabelsForSelfHostedRunnerForRepo");
            

            var path = "/repos/{owner}/{repo}/actions/runners/{runner_id}/labels";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "runner_id" + "}", ApiClient.ParameterToString(runnerId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsListLabelsForSelfHostedRunnerForRepo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsListLabelsForSelfHostedRunnerForRepo: " + response.ErrorMessage, response.ErrorMessage);

            return (EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response) ApiClient.Deserialize(response.Content, typeof(EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response), response.Headers);
        }

        /// <summary>
        /// List organization secrets Lists all secrets available in an organization without revealing their encrypted values. You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;secrets&#x60; organization permission to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>ActionsListOrgSecrets200Response</returns>
        public ActionsListOrgSecrets200Response ActionsListOrgSecrets (string org, int? perPage, int? page)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling ActionsListOrgSecrets");
            

            var path = "/orgs/{org}/actions/secrets";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsListOrgSecrets: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsListOrgSecrets: " + response.ErrorMessage, response.ErrorMessage);

            return (ActionsListOrgSecrets200Response) ApiClient.Deserialize(response.Content, typeof(ActionsListOrgSecrets200Response), response.Headers);
        }

        /// <summary>
        /// List repository access to a self-hosted runner group in an organization The self-hosted runner groups REST API is available with GitHub Enterprise Cloud and GitHub Enterprise Server. For more information, see \&quot;[GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products).\&quot;  Lists the repositories with access to a self-hosted runner group configured in an organization.  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="runnerGroupId">Unique identifier of the self-hosted runner group.</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <returns>ActionsListRepoAccessToSelfHostedRunnerGroupInOrg200Response</returns>
        public ActionsListRepoAccessToSelfHostedRunnerGroupInOrg200Response ActionsListRepoAccessToSelfHostedRunnerGroupInOrg (string org, int? runnerGroupId, int? page, int? perPage)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling ActionsListRepoAccessToSelfHostedRunnerGroupInOrg");
            
            // verify the required parameter 'runnerGroupId' is set
            if (runnerGroupId == null) throw new ApiException(400, "Missing required parameter 'runnerGroupId' when calling ActionsListRepoAccessToSelfHostedRunnerGroupInOrg");
            

            var path = "/orgs/{org}/actions/runner-groups/{runner_group_id}/repositories";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "runner_group_id" + "}", ApiClient.ParameterToString(runnerGroupId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsListRepoAccessToSelfHostedRunnerGroupInOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsListRepoAccessToSelfHostedRunnerGroupInOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (ActionsListRepoAccessToSelfHostedRunnerGroupInOrg200Response) ApiClient.Deserialize(response.Content, typeof(ActionsListRepoAccessToSelfHostedRunnerGroupInOrg200Response), response.Headers);
        }

        /// <summary>
        /// List repository secrets Lists all secrets available in a repository without revealing their encrypted values. You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;secrets&#x60; repository permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>ActionsListRepoSecrets200Response</returns>
        public ActionsListRepoSecrets200Response ActionsListRepoSecrets (string owner, string repo, int? perPage, int? page)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActionsListRepoSecrets");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActionsListRepoSecrets");
            

            var path = "/repos/{owner}/{repo}/actions/secrets";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsListRepoSecrets: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsListRepoSecrets: " + response.ErrorMessage, response.ErrorMessage);

            return (ActionsListRepoSecrets200Response) ApiClient.Deserialize(response.Content, typeof(ActionsListRepoSecrets200Response), response.Headers);
        }

        /// <summary>
        /// List repository workflows Lists the workflows in a repository. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the &#x60;repo&#x60; scope. GitHub Apps must have the &#x60;actions:read&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>ActionsListRepoWorkflows200Response</returns>
        public ActionsListRepoWorkflows200Response ActionsListRepoWorkflows (string owner, string repo, int? perPage, int? page)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActionsListRepoWorkflows");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActionsListRepoWorkflows");
            

            var path = "/repos/{owner}/{repo}/actions/workflows";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsListRepoWorkflows: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsListRepoWorkflows: " + response.ErrorMessage, response.ErrorMessage);

            return (ActionsListRepoWorkflows200Response) ApiClient.Deserialize(response.Content, typeof(ActionsListRepoWorkflows200Response), response.Headers);
        }

        /// <summary>
        /// List runner applications for an organization Lists binaries for the runner application that you can download and run.  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <returns>List&lt;RunnerApplication&gt;</returns>
        public List<RunnerApplication> ActionsListRunnerApplicationsForOrg (string org)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling ActionsListRunnerApplicationsForOrg");
            

            var path = "/orgs/{org}/actions/runners/downloads";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsListRunnerApplicationsForOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsListRunnerApplicationsForOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (List<RunnerApplication>) ApiClient.Deserialize(response.Content, typeof(List<RunnerApplication>), response.Headers);
        }

        /// <summary>
        /// List runner applications for a repository Lists binaries for the runner application that you can download and run.  You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>List&lt;RunnerApplication&gt;</returns>
        public List<RunnerApplication> ActionsListRunnerApplicationsForRepo (string owner, string repo)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActionsListRunnerApplicationsForRepo");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActionsListRunnerApplicationsForRepo");
            

            var path = "/repos/{owner}/{repo}/actions/runners/downloads";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsListRunnerApplicationsForRepo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsListRunnerApplicationsForRepo: " + response.ErrorMessage, response.ErrorMessage);

            return (List<RunnerApplication>) ApiClient.Deserialize(response.Content, typeof(List<RunnerApplication>), response.Headers);
        }

        /// <summary>
        /// List selected repositories for an organization secret Lists all repositories that have been selected when the &#x60;visibility&#x60; for repository access to a secret is set to &#x60;selected&#x60;. You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;secrets&#x60; organization permission to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="secretName">The name of the secret.</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <returns>ActionsListSelectedReposForOrgSecret200Response</returns>
        public ActionsListSelectedReposForOrgSecret200Response ActionsListSelectedReposForOrgSecret (string org, string secretName, int? page, int? perPage)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling ActionsListSelectedReposForOrgSecret");
            
            // verify the required parameter 'secretName' is set
            if (secretName == null) throw new ApiException(400, "Missing required parameter 'secretName' when calling ActionsListSelectedReposForOrgSecret");
            

            var path = "/orgs/{org}/actions/secrets/{secret_name}/repositories";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsListSelectedReposForOrgSecret: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsListSelectedReposForOrgSecret: " + response.ErrorMessage, response.ErrorMessage);

            return (ActionsListSelectedReposForOrgSecret200Response) ApiClient.Deserialize(response.Content, typeof(ActionsListSelectedReposForOrgSecret200Response), response.Headers);
        }

        /// <summary>
        /// List selected repositories enabled for GitHub Actions in an organization Lists the selected repositories that are enabled for GitHub Actions in an organization. To use this endpoint, the organization permission policy for &#x60;enabled_repositories&#x60; must be configured to &#x60;selected&#x60;. For more information, see \&quot;[Set GitHub Actions permissions for an organization](#set-github-actions-permissions-for-an-organization).\&quot;  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;administration&#x60; organization permission to use this API.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>ActionsListSelectedRepositoriesEnabledGithubActionsOrganization200Response</returns>
        public ActionsListSelectedRepositoriesEnabledGithubActionsOrganization200Response ActionsListSelectedRepositoriesEnabledGithubActionsOrganization (string org, int? perPage, int? page)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling ActionsListSelectedRepositoriesEnabledGithubActionsOrganization");
            

            var path = "/orgs/{org}/actions/permissions/repositories";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsListSelectedRepositoriesEnabledGithubActionsOrganization: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsListSelectedRepositoriesEnabledGithubActionsOrganization: " + response.ErrorMessage, response.ErrorMessage);

            return (ActionsListSelectedRepositoriesEnabledGithubActionsOrganization200Response) ApiClient.Deserialize(response.Content, typeof(ActionsListSelectedRepositoriesEnabledGithubActionsOrganization200Response), response.Headers);
        }

        /// <summary>
        /// List self-hosted runner groups for an organization The self-hosted runner groups REST API is available with GitHub Enterprise Cloud. For more information, see \&quot;[GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products).\&quot;  Lists all self-hosted runner groups configured in an organization and inherited from an enterprise.  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <param name="visibleToRepository">Only return runner groups that are allowed to be used by this repository.</param>
        /// <returns>ActionsListSelfHostedRunnerGroupsForOrg200Response</returns>
        public ActionsListSelfHostedRunnerGroupsForOrg200Response ActionsListSelfHostedRunnerGroupsForOrg (string org, int? perPage, int? page, string visibleToRepository)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling ActionsListSelfHostedRunnerGroupsForOrg");
            

            var path = "/orgs/{org}/actions/runner-groups";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (visibleToRepository != null) queryParams.Add("visible_to_repository", ApiClient.ParameterToString(visibleToRepository)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsListSelfHostedRunnerGroupsForOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsListSelfHostedRunnerGroupsForOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (ActionsListSelfHostedRunnerGroupsForOrg200Response) ApiClient.Deserialize(response.Content, typeof(ActionsListSelfHostedRunnerGroupsForOrg200Response), response.Headers);
        }

        /// <summary>
        /// List self-hosted runners for an organization Lists all self-hosted runners configured in an organization.  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>ActionsListSelfHostedRunnersForOrg200Response</returns>
        public ActionsListSelfHostedRunnersForOrg200Response ActionsListSelfHostedRunnersForOrg (string org, int? perPage, int? page)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling ActionsListSelfHostedRunnersForOrg");
            

            var path = "/orgs/{org}/actions/runners";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsListSelfHostedRunnersForOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsListSelfHostedRunnersForOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (ActionsListSelfHostedRunnersForOrg200Response) ApiClient.Deserialize(response.Content, typeof(ActionsListSelfHostedRunnersForOrg200Response), response.Headers);
        }

        /// <summary>
        /// List self-hosted runners for a repository Lists all self-hosted runners configured in a repository. You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>ActionsListSelfHostedRunnersForOrg200Response</returns>
        public ActionsListSelfHostedRunnersForOrg200Response ActionsListSelfHostedRunnersForRepo (string owner, string repo, int? perPage, int? page)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActionsListSelfHostedRunnersForRepo");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActionsListSelfHostedRunnersForRepo");
            

            var path = "/repos/{owner}/{repo}/actions/runners";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsListSelfHostedRunnersForRepo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsListSelfHostedRunnersForRepo: " + response.ErrorMessage, response.ErrorMessage);

            return (ActionsListSelfHostedRunnersForOrg200Response) ApiClient.Deserialize(response.Content, typeof(ActionsListSelfHostedRunnersForOrg200Response), response.Headers);
        }

        /// <summary>
        /// List self-hosted runners in a group for an organization The self-hosted runner groups REST API is available with GitHub Enterprise Cloud. For more information, see \&quot;[GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products).\&quot;  Lists self-hosted runners that are in a specific organization group.  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="runnerGroupId">Unique identifier of the self-hosted runner group.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>EnterpriseAdminListSelfHostedRunnersInGroupForEnterprise200Response</returns>
        public EnterpriseAdminListSelfHostedRunnersInGroupForEnterprise200Response ActionsListSelfHostedRunnersInGroupForOrg (string org, int? runnerGroupId, int? perPage, int? page)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling ActionsListSelfHostedRunnersInGroupForOrg");
            
            // verify the required parameter 'runnerGroupId' is set
            if (runnerGroupId == null) throw new ApiException(400, "Missing required parameter 'runnerGroupId' when calling ActionsListSelfHostedRunnersInGroupForOrg");
            

            var path = "/orgs/{org}/actions/runner-groups/{runner_group_id}/runners";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "runner_group_id" + "}", ApiClient.ParameterToString(runnerGroupId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsListSelfHostedRunnersInGroupForOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsListSelfHostedRunnersInGroupForOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (EnterpriseAdminListSelfHostedRunnersInGroupForEnterprise200Response) ApiClient.Deserialize(response.Content, typeof(EnterpriseAdminListSelfHostedRunnersInGroupForEnterprise200Response), response.Headers);
        }

        /// <summary>
        /// List workflow run artifacts Lists artifacts for a workflow run. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the &#x60;repo&#x60; scope. GitHub Apps must have the &#x60;actions:read&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="runId">The unique identifier of the workflow run.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>ActionsListArtifactsForRepo200Response</returns>
        public ActionsListArtifactsForRepo200Response ActionsListWorkflowRunArtifacts (string owner, string repo, int? runId, int? perPage, int? page)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActionsListWorkflowRunArtifacts");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActionsListWorkflowRunArtifacts");
            
            // verify the required parameter 'runId' is set
            if (runId == null) throw new ApiException(400, "Missing required parameter 'runId' when calling ActionsListWorkflowRunArtifacts");
            

            var path = "/repos/{owner}/{repo}/actions/runs/{run_id}/artifacts";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "run_id" + "}", ApiClient.ParameterToString(runId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsListWorkflowRunArtifacts: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsListWorkflowRunArtifacts: " + response.ErrorMessage, response.ErrorMessage);

            return (ActionsListArtifactsForRepo200Response) ApiClient.Deserialize(response.Content, typeof(ActionsListArtifactsForRepo200Response), response.Headers);
        }

        /// <summary>
        /// List workflow runs List all workflow runs for a workflow. You can replace &#x60;workflow_id&#x60; with the workflow file name. For example, you could use &#x60;main.yaml&#x60;. You can use parameters to narrow the list of results. For more information about using parameters, see [Parameters](https://docs.github.com/rest/overview/resources-in-the-rest-api#parameters).  Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the &#x60;repo&#x60; scope.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="workflowId">The ID of the workflow. You can also pass the workflow file name as a string.</param>
        /// <param name="actor">Returns someone&#39;s workflow runs. Use the login for the user who created the &#x60;push&#x60; associated with the check suite or workflow run.</param>
        /// <param name="branch">Returns workflow runs associated with a branch. Use the name of the branch of the &#x60;push&#x60;.</param>
        /// <param name="_event">Returns workflow run triggered by the event you specify. For example, &#x60;push&#x60;, &#x60;pull_request&#x60; or &#x60;issue&#x60;. For more information, see \&quot;[Events that trigger workflows](https://docs.github.com/en/actions/automating-your-workflow-with-github-actions/events-that-trigger-workflows).\&quot;</param>
        /// <param name="status">Returns workflow runs with the check run &#x60;status&#x60; or &#x60;conclusion&#x60; that you specify. For example, a conclusion can be &#x60;success&#x60; or a status can be &#x60;in_progress&#x60;. Only GitHub can set a status of &#x60;waiting&#x60; or &#x60;requested&#x60;.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <param name="created">Returns workflow runs created within the given date-time range. For more information on the syntax, see \&quot;[Understanding the search syntax](https://docs.github.com/search-github/getting-started-with-searching-on-github/understanding-the-search-syntax#query-for-dates).\&quot;</param>
        /// <param name="excludePullRequests">If &#x60;true&#x60; pull requests are omitted from the response (empty array).</param>
        /// <param name="checkSuiteId">Returns workflow runs with the &#x60;check_suite_id&#x60; that you specify.</param>
        /// <returns>ActionsListWorkflowRunsForRepo200Response</returns>
        public ActionsListWorkflowRunsForRepo200Response ActionsListWorkflowRuns (string owner, string repo, ActionsGetWorkflowWorkflowIdParameter workflowId, string actor, string branch, string _event, string status, int? perPage, int? page, DateTime? created, bool? excludePullRequests, int? checkSuiteId)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActionsListWorkflowRuns");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActionsListWorkflowRuns");
            
            // verify the required parameter 'workflowId' is set
            if (workflowId == null) throw new ApiException(400, "Missing required parameter 'workflowId' when calling ActionsListWorkflowRuns");
            

            var path = "/repos/{owner}/{repo}/actions/workflows/{workflow_id}/runs";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "workflow_id" + "}", ApiClient.ParameterToString(workflowId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (actor != null) queryParams.Add("actor", ApiClient.ParameterToString(actor)); // query parameter
 if (branch != null) queryParams.Add("branch", ApiClient.ParameterToString(branch)); // query parameter
 if (_event != null) queryParams.Add("event", ApiClient.ParameterToString(_event)); // query parameter
 if (status != null) queryParams.Add("status", ApiClient.ParameterToString(status)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (created != null) queryParams.Add("created", ApiClient.ParameterToString(created)); // query parameter
 if (excludePullRequests != null) queryParams.Add("exclude_pull_requests", ApiClient.ParameterToString(excludePullRequests)); // query parameter
 if (checkSuiteId != null) queryParams.Add("check_suite_id", ApiClient.ParameterToString(checkSuiteId)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsListWorkflowRuns: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsListWorkflowRuns: " + response.ErrorMessage, response.ErrorMessage);

            return (ActionsListWorkflowRunsForRepo200Response) ApiClient.Deserialize(response.Content, typeof(ActionsListWorkflowRunsForRepo200Response), response.Headers);
        }

        /// <summary>
        /// List workflow runs for a repository Lists all workflow runs for a repository. You can use parameters to narrow the list of results. For more information about using parameters, see [Parameters](https://docs.github.com/rest/overview/resources-in-the-rest-api#parameters).  Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the &#x60;repo&#x60; scope. GitHub Apps must have the &#x60;actions:read&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="actor">Returns someone&#39;s workflow runs. Use the login for the user who created the &#x60;push&#x60; associated with the check suite or workflow run.</param>
        /// <param name="branch">Returns workflow runs associated with a branch. Use the name of the branch of the &#x60;push&#x60;.</param>
        /// <param name="_event">Returns workflow run triggered by the event you specify. For example, &#x60;push&#x60;, &#x60;pull_request&#x60; or &#x60;issue&#x60;. For more information, see \&quot;[Events that trigger workflows](https://docs.github.com/en/actions/automating-your-workflow-with-github-actions/events-that-trigger-workflows).\&quot;</param>
        /// <param name="status">Returns workflow runs with the check run &#x60;status&#x60; or &#x60;conclusion&#x60; that you specify. For example, a conclusion can be &#x60;success&#x60; or a status can be &#x60;in_progress&#x60;. Only GitHub can set a status of &#x60;waiting&#x60; or &#x60;requested&#x60;.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <param name="created">Returns workflow runs created within the given date-time range. For more information on the syntax, see \&quot;[Understanding the search syntax](https://docs.github.com/search-github/getting-started-with-searching-on-github/understanding-the-search-syntax#query-for-dates).\&quot;</param>
        /// <param name="excludePullRequests">If &#x60;true&#x60; pull requests are omitted from the response (empty array).</param>
        /// <param name="checkSuiteId">Returns workflow runs with the &#x60;check_suite_id&#x60; that you specify.</param>
        /// <returns>ActionsListWorkflowRunsForRepo200Response</returns>
        public ActionsListWorkflowRunsForRepo200Response ActionsListWorkflowRunsForRepo (string owner, string repo, string actor, string branch, string _event, string status, int? perPage, int? page, DateTime? created, bool? excludePullRequests, int? checkSuiteId)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActionsListWorkflowRunsForRepo");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActionsListWorkflowRunsForRepo");
            

            var path = "/repos/{owner}/{repo}/actions/runs";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (actor != null) queryParams.Add("actor", ApiClient.ParameterToString(actor)); // query parameter
 if (branch != null) queryParams.Add("branch", ApiClient.ParameterToString(branch)); // query parameter
 if (_event != null) queryParams.Add("event", ApiClient.ParameterToString(_event)); // query parameter
 if (status != null) queryParams.Add("status", ApiClient.ParameterToString(status)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (created != null) queryParams.Add("created", ApiClient.ParameterToString(created)); // query parameter
 if (excludePullRequests != null) queryParams.Add("exclude_pull_requests", ApiClient.ParameterToString(excludePullRequests)); // query parameter
 if (checkSuiteId != null) queryParams.Add("check_suite_id", ApiClient.ParameterToString(checkSuiteId)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsListWorkflowRunsForRepo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsListWorkflowRunsForRepo: " + response.ErrorMessage, response.ErrorMessage);

            return (ActionsListWorkflowRunsForRepo200Response) ApiClient.Deserialize(response.Content, typeof(ActionsListWorkflowRunsForRepo200Response), response.Headers);
        }

        /// <summary>
        /// Re-run a job from a workflow run Re-run a job and its dependent jobs in a workflow run. You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;actions:write&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="jobId">The unique identifier of the job.</param>
        /// <param name="actionsReRunJobForWorkflowRunRequest"></param>
        /// <returns>Object</returns>
        public Object ActionsReRunJobForWorkflowRun (string owner, string repo, int? jobId, ActionsReRunJobForWorkflowRunRequest actionsReRunJobForWorkflowRunRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActionsReRunJobForWorkflowRun");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActionsReRunJobForWorkflowRun");
            
            // verify the required parameter 'jobId' is set
            if (jobId == null) throw new ApiException(400, "Missing required parameter 'jobId' when calling ActionsReRunJobForWorkflowRun");
            

            var path = "/repos/{owner}/{repo}/actions/jobs/{job_id}/rerun";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "job_id" + "}", ApiClient.ParameterToString(jobId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(actionsReRunJobForWorkflowRunRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsReRunJobForWorkflowRun: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsReRunJobForWorkflowRun: " + response.ErrorMessage, response.ErrorMessage);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }

        /// <summary>
        /// Re-run a workflow Re-runs your workflow run using its &#x60;id&#x60;. You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;actions:write&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="runId">The unique identifier of the workflow run.</param>
        /// <param name="actionsReRunJobForWorkflowRunRequest"></param>
        /// <returns>Object</returns>
        public Object ActionsReRunWorkflow (string owner, string repo, int? runId, ActionsReRunJobForWorkflowRunRequest actionsReRunJobForWorkflowRunRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActionsReRunWorkflow");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActionsReRunWorkflow");
            
            // verify the required parameter 'runId' is set
            if (runId == null) throw new ApiException(400, "Missing required parameter 'runId' when calling ActionsReRunWorkflow");
            

            var path = "/repos/{owner}/{repo}/actions/runs/{run_id}/rerun";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "run_id" + "}", ApiClient.ParameterToString(runId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(actionsReRunJobForWorkflowRunRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsReRunWorkflow: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsReRunWorkflow: " + response.ErrorMessage, response.ErrorMessage);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }

        /// <summary>
        /// Re-run failed jobs from a workflow run Re-run all of the failed jobs and their dependent jobs in a workflow run using the &#x60;id&#x60; of the workflow run. You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="runId">The unique identifier of the workflow run.</param>
        /// <param name="actionsReRunJobForWorkflowRunRequest"></param>
        /// <returns>Object</returns>
        public Object ActionsReRunWorkflowFailedJobs (string owner, string repo, int? runId, ActionsReRunJobForWorkflowRunRequest actionsReRunJobForWorkflowRunRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActionsReRunWorkflowFailedJobs");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActionsReRunWorkflowFailedJobs");
            
            // verify the required parameter 'runId' is set
            if (runId == null) throw new ApiException(400, "Missing required parameter 'runId' when calling ActionsReRunWorkflowFailedJobs");
            

            var path = "/repos/{owner}/{repo}/actions/runs/{run_id}/rerun-failed-jobs";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "run_id" + "}", ApiClient.ParameterToString(runId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(actionsReRunJobForWorkflowRunRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsReRunWorkflowFailedJobs: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsReRunWorkflowFailedJobs: " + response.ErrorMessage, response.ErrorMessage);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }

        /// <summary>
        /// Remove all custom labels from a self-hosted runner for an organization Remove all custom labels from a self-hosted runner configured in an organization. Returns the remaining read-only labels from the runner.  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="runnerId">Unique identifier of the self-hosted runner.</param>
        /// <returns>EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response</returns>
        public EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response ActionsRemoveAllCustomLabelsFromSelfHostedRunnerForOrg (string org, int? runnerId)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling ActionsRemoveAllCustomLabelsFromSelfHostedRunnerForOrg");
            
            // verify the required parameter 'runnerId' is set
            if (runnerId == null) throw new ApiException(400, "Missing required parameter 'runnerId' when calling ActionsRemoveAllCustomLabelsFromSelfHostedRunnerForOrg");
            

            var path = "/orgs/{org}/actions/runners/{runner_id}/labels";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "runner_id" + "}", ApiClient.ParameterToString(runnerId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsRemoveAllCustomLabelsFromSelfHostedRunnerForOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsRemoveAllCustomLabelsFromSelfHostedRunnerForOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response) ApiClient.Deserialize(response.Content, typeof(EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response), response.Headers);
        }

        /// <summary>
        /// Remove all custom labels from a self-hosted runner for a repository Remove all custom labels from a self-hosted runner configured in a repository. Returns the remaining read-only labels from the runner.  You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="runnerId">Unique identifier of the self-hosted runner.</param>
        /// <returns>EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response</returns>
        public EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response ActionsRemoveAllCustomLabelsFromSelfHostedRunnerForRepo (string owner, string repo, int? runnerId)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActionsRemoveAllCustomLabelsFromSelfHostedRunnerForRepo");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActionsRemoveAllCustomLabelsFromSelfHostedRunnerForRepo");
            
            // verify the required parameter 'runnerId' is set
            if (runnerId == null) throw new ApiException(400, "Missing required parameter 'runnerId' when calling ActionsRemoveAllCustomLabelsFromSelfHostedRunnerForRepo");
            

            var path = "/repos/{owner}/{repo}/actions/runners/{runner_id}/labels";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "runner_id" + "}", ApiClient.ParameterToString(runnerId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsRemoveAllCustomLabelsFromSelfHostedRunnerForRepo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsRemoveAllCustomLabelsFromSelfHostedRunnerForRepo: " + response.ErrorMessage, response.ErrorMessage);

            return (EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response) ApiClient.Deserialize(response.Content, typeof(EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response), response.Headers);
        }

        /// <summary>
        /// Remove a custom label from a self-hosted runner for an organization Remove a custom label from a self-hosted runner configured in an organization. Returns the remaining labels from the runner.  This endpoint returns a &#x60;404 Not Found&#x60; status if the custom label is not present on the runner.  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="runnerId">Unique identifier of the self-hosted runner.</param>
        /// <param name="name">The name of a self-hosted runner&#39;s custom label.</param>
        /// <returns>EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response</returns>
        public EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response ActionsRemoveCustomLabelFromSelfHostedRunnerForOrg (string org, int? runnerId, string name)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling ActionsRemoveCustomLabelFromSelfHostedRunnerForOrg");
            
            // verify the required parameter 'runnerId' is set
            if (runnerId == null) throw new ApiException(400, "Missing required parameter 'runnerId' when calling ActionsRemoveCustomLabelFromSelfHostedRunnerForOrg");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ActionsRemoveCustomLabelFromSelfHostedRunnerForOrg");
            

            var path = "/orgs/{org}/actions/runners/{runner_id}/labels/{name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "runner_id" + "}", ApiClient.ParameterToString(runnerId));
path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsRemoveCustomLabelFromSelfHostedRunnerForOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsRemoveCustomLabelFromSelfHostedRunnerForOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response) ApiClient.Deserialize(response.Content, typeof(EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response), response.Headers);
        }

        /// <summary>
        /// Remove a custom label from a self-hosted runner for a repository Remove a custom label from a self-hosted runner configured in a repository. Returns the remaining labels from the runner.  This endpoint returns a &#x60;404 Not Found&#x60; status if the custom label is not present on the runner.  You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="runnerId">Unique identifier of the self-hosted runner.</param>
        /// <param name="name">The name of a self-hosted runner&#39;s custom label.</param>
        /// <returns>EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response</returns>
        public EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response ActionsRemoveCustomLabelFromSelfHostedRunnerForRepo (string owner, string repo, int? runnerId, string name)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActionsRemoveCustomLabelFromSelfHostedRunnerForRepo");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActionsRemoveCustomLabelFromSelfHostedRunnerForRepo");
            
            // verify the required parameter 'runnerId' is set
            if (runnerId == null) throw new ApiException(400, "Missing required parameter 'runnerId' when calling ActionsRemoveCustomLabelFromSelfHostedRunnerForRepo");
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling ActionsRemoveCustomLabelFromSelfHostedRunnerForRepo");
            

            var path = "/repos/{owner}/{repo}/actions/runners/{runner_id}/labels/{name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "runner_id" + "}", ApiClient.ParameterToString(runnerId));
path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsRemoveCustomLabelFromSelfHostedRunnerForRepo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsRemoveCustomLabelFromSelfHostedRunnerForRepo: " + response.ErrorMessage, response.ErrorMessage);

            return (EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response) ApiClient.Deserialize(response.Content, typeof(EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response), response.Headers);
        }

        /// <summary>
        /// Remove repository access to a self-hosted runner group in an organization The self-hosted runner groups REST API is available with GitHub Enterprise Cloud. For more information, see \&quot;[GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products).\&quot;   Removes a repository from the list of selected repositories that can access a self-hosted runner group. The runner group must have &#x60;visibility&#x60; set to &#x60;selected&#x60;. For more information, see \&quot;[Create a self-hosted runner group for an organization](#create-a-self-hosted-runner-group-for-an-organization).\&quot;  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="runnerGroupId">Unique identifier of the self-hosted runner group.</param>
        /// <param name="repositoryId">The unique identifier of the repository.</param>
        /// <returns></returns>
        public void ActionsRemoveRepoAccessToSelfHostedRunnerGroupInOrg (string org, int? runnerGroupId, int? repositoryId)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling ActionsRemoveRepoAccessToSelfHostedRunnerGroupInOrg");
            
            // verify the required parameter 'runnerGroupId' is set
            if (runnerGroupId == null) throw new ApiException(400, "Missing required parameter 'runnerGroupId' when calling ActionsRemoveRepoAccessToSelfHostedRunnerGroupInOrg");
            
            // verify the required parameter 'repositoryId' is set
            if (repositoryId == null) throw new ApiException(400, "Missing required parameter 'repositoryId' when calling ActionsRemoveRepoAccessToSelfHostedRunnerGroupInOrg");
            

            var path = "/orgs/{org}/actions/runner-groups/{runner_group_id}/repositories/{repository_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "runner_group_id" + "}", ApiClient.ParameterToString(runnerGroupId));
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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsRemoveRepoAccessToSelfHostedRunnerGroupInOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsRemoveRepoAccessToSelfHostedRunnerGroupInOrg: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Remove selected repository from an organization secret Removes a repository from an organization secret when the &#x60;visibility&#x60; for repository access is set to &#x60;selected&#x60;. The visibility is set when you [Create or update an organization secret](https://docs.github.com/rest/reference/actions#create-or-update-an-organization-secret). You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;secrets&#x60; organization permission to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="secretName">The name of the secret.</param>
        /// <param name="repositoryId"></param>
        /// <returns></returns>
        public void ActionsRemoveSelectedRepoFromOrgSecret (string org, string secretName, int? repositoryId)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling ActionsRemoveSelectedRepoFromOrgSecret");
            
            // verify the required parameter 'secretName' is set
            if (secretName == null) throw new ApiException(400, "Missing required parameter 'secretName' when calling ActionsRemoveSelectedRepoFromOrgSecret");
            
            // verify the required parameter 'repositoryId' is set
            if (repositoryId == null) throw new ApiException(400, "Missing required parameter 'repositoryId' when calling ActionsRemoveSelectedRepoFromOrgSecret");
            

            var path = "/orgs/{org}/actions/secrets/{secret_name}/repositories/{repository_id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsRemoveSelectedRepoFromOrgSecret: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsRemoveSelectedRepoFromOrgSecret: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Remove a self-hosted runner from a group for an organization The self-hosted runner groups REST API is available with GitHub Enterprise Cloud. For more information, see \&quot;[GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products).\&quot;   Removes a self-hosted runner from a group configured in an organization. The runner is then returned to the default group.  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="runnerGroupId">Unique identifier of the self-hosted runner group.</param>
        /// <param name="runnerId">Unique identifier of the self-hosted runner.</param>
        /// <returns></returns>
        public void ActionsRemoveSelfHostedRunnerFromGroupForOrg (string org, int? runnerGroupId, int? runnerId)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling ActionsRemoveSelfHostedRunnerFromGroupForOrg");
            
            // verify the required parameter 'runnerGroupId' is set
            if (runnerGroupId == null) throw new ApiException(400, "Missing required parameter 'runnerGroupId' when calling ActionsRemoveSelfHostedRunnerFromGroupForOrg");
            
            // verify the required parameter 'runnerId' is set
            if (runnerId == null) throw new ApiException(400, "Missing required parameter 'runnerId' when calling ActionsRemoveSelfHostedRunnerFromGroupForOrg");
            

            var path = "/orgs/{org}/actions/runner-groups/{runner_group_id}/runners/{runner_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "runner_group_id" + "}", ApiClient.ParameterToString(runnerGroupId));
path = path.Replace("{" + "runner_id" + "}", ApiClient.ParameterToString(runnerId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsRemoveSelfHostedRunnerFromGroupForOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsRemoveSelfHostedRunnerFromGroupForOrg: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Review pending deployments for a workflow run Approve or reject pending deployments that are waiting on approval by a required reviewer.  Required reviewers with read access to the repository contents and deployments can use this endpoint. Required reviewers must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="runId">The unique identifier of the workflow run.</param>
        /// <param name="actionsReviewPendingDeploymentsForRunRequest"></param>
        /// <returns>List&lt;Deployment&gt;</returns>
        public List<Deployment> ActionsReviewPendingDeploymentsForRun (string owner, string repo, int? runId, ActionsReviewPendingDeploymentsForRunRequest actionsReviewPendingDeploymentsForRunRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActionsReviewPendingDeploymentsForRun");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActionsReviewPendingDeploymentsForRun");
            
            // verify the required parameter 'runId' is set
            if (runId == null) throw new ApiException(400, "Missing required parameter 'runId' when calling ActionsReviewPendingDeploymentsForRun");
            
            // verify the required parameter 'actionsReviewPendingDeploymentsForRunRequest' is set
            if (actionsReviewPendingDeploymentsForRunRequest == null) throw new ApiException(400, "Missing required parameter 'actionsReviewPendingDeploymentsForRunRequest' when calling ActionsReviewPendingDeploymentsForRun");
            

            var path = "/repos/{owner}/{repo}/actions/runs/{run_id}/pending_deployments";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "run_id" + "}", ApiClient.ParameterToString(runId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(actionsReviewPendingDeploymentsForRunRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsReviewPendingDeploymentsForRun: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsReviewPendingDeploymentsForRun: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Deployment>) ApiClient.Deserialize(response.Content, typeof(List<Deployment>), response.Headers);
        }

        /// <summary>
        /// Set the GitHub Actions OIDC custom issuer policy for an enterprise Sets the GitHub Actions OpenID Connect (OIDC) custom issuer policy for an enterprise. You must authenticate using an access token with the &#x60;admin:enterprise&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;enterprise_administration:write&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="actionsSetActionsOidcCustomIssuerPolicyForEnterpriseRequest"></param>
        /// <returns></returns>
        public void ActionsSetActionsOidcCustomIssuerPolicyForEnterprise (string enterprise, ActionsSetActionsOidcCustomIssuerPolicyForEnterpriseRequest actionsSetActionsOidcCustomIssuerPolicyForEnterpriseRequest)
        {
            
            // verify the required parameter 'enterprise' is set
            if (enterprise == null) throw new ApiException(400, "Missing required parameter 'enterprise' when calling ActionsSetActionsOidcCustomIssuerPolicyForEnterprise");
            
            // verify the required parameter 'actionsSetActionsOidcCustomIssuerPolicyForEnterpriseRequest' is set
            if (actionsSetActionsOidcCustomIssuerPolicyForEnterpriseRequest == null) throw new ApiException(400, "Missing required parameter 'actionsSetActionsOidcCustomIssuerPolicyForEnterpriseRequest' when calling ActionsSetActionsOidcCustomIssuerPolicyForEnterprise");
            

            var path = "/enterprises/{enterprise}/actions/oidc/customization/issuer";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "enterprise" + "}", ApiClient.ParameterToString(enterprise));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(actionsSetActionsOidcCustomIssuerPolicyForEnterpriseRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsSetActionsOidcCustomIssuerPolicyForEnterprise: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsSetActionsOidcCustomIssuerPolicyForEnterprise: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Set allowed actions and reusable workflows for an organization Sets the actions and reusable workflows that are allowed in an organization. To use this endpoint, the organization permission policy for &#x60;allowed_actions&#x60; must be configured to &#x60;selected&#x60;. For more information, see \&quot;[Set GitHub Actions permissions for an organization](#set-github-actions-permissions-for-an-organization).\&quot;  If the organization belongs to an enterprise that has &#x60;selected&#x60; actions and reusable workflows set at the enterprise level, then you cannot override any of the enterprise&#39;s allowed actions and reusable workflows settings.  To use the &#x60;patterns_allowed&#x60; setting for private repositories, the organization must belong to an enterprise. If the organization does not belong to an enterprise, then the &#x60;patterns_allowed&#x60; setting only applies to public repositories in the organization.  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;administration&#x60; organization permission to use this API.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="enterpriseAdminGetAllowedActionsEnterprise200Response"></param>
        /// <returns></returns>
        public void ActionsSetAllowedActionsOrganization (string org, EnterpriseAdminGetAllowedActionsEnterprise200Response enterpriseAdminGetAllowedActionsEnterprise200Response)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling ActionsSetAllowedActionsOrganization");
            

            var path = "/orgs/{org}/actions/permissions/selected-actions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(enterpriseAdminGetAllowedActionsEnterprise200Response); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsSetAllowedActionsOrganization: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsSetAllowedActionsOrganization: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Set allowed actions and reusable workflows for a repository Sets the actions and reusable workflows that are allowed in a repository. To use this endpoint, the repository permission policy for &#x60;allowed_actions&#x60; must be configured to &#x60;selected&#x60;. For more information, see \&quot;[Set GitHub Actions permissions for a repository](#set-github-actions-permissions-for-a-repository).\&quot;  If the repository belongs to an organization or enterprise that has &#x60;selected&#x60; actions and reusable workflows set at the organization or enterprise levels, then you cannot override any of the allowed actions and reusable workflows settings.  To use the &#x60;patterns_allowed&#x60; setting for private repositories, the repository must belong to an enterprise. If the repository does not belong to an enterprise, then the &#x60;patterns_allowed&#x60; setting only applies to public repositories.  You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;administration&#x60; repository permission to use this API.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="enterpriseAdminGetAllowedActionsEnterprise200Response"></param>
        /// <returns></returns>
        public void ActionsSetAllowedActionsRepository (string owner, string repo, EnterpriseAdminGetAllowedActionsEnterprise200Response enterpriseAdminGetAllowedActionsEnterprise200Response)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActionsSetAllowedActionsRepository");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActionsSetAllowedActionsRepository");
            

            var path = "/repos/{owner}/{repo}/actions/permissions/selected-actions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(enterpriseAdminGetAllowedActionsEnterprise200Response); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsSetAllowedActionsRepository: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsSetAllowedActionsRepository: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Set custom labels for a self-hosted runner for an organization Remove all previous custom labels and set the new custom labels for a specific self-hosted runner configured in an organization.  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="runnerId">Unique identifier of the self-hosted runner.</param>
        /// <param name="enterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest"></param>
        /// <returns>EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response</returns>
        public EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response ActionsSetCustomLabelsForSelfHostedRunnerForOrg (string org, int? runnerId, EnterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest enterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling ActionsSetCustomLabelsForSelfHostedRunnerForOrg");
            
            // verify the required parameter 'runnerId' is set
            if (runnerId == null) throw new ApiException(400, "Missing required parameter 'runnerId' when calling ActionsSetCustomLabelsForSelfHostedRunnerForOrg");
            
            // verify the required parameter 'enterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest' is set
            if (enterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest == null) throw new ApiException(400, "Missing required parameter 'enterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest' when calling ActionsSetCustomLabelsForSelfHostedRunnerForOrg");
            

            var path = "/orgs/{org}/actions/runners/{runner_id}/labels";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "runner_id" + "}", ApiClient.ParameterToString(runnerId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(enterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsSetCustomLabelsForSelfHostedRunnerForOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsSetCustomLabelsForSelfHostedRunnerForOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response) ApiClient.Deserialize(response.Content, typeof(EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response), response.Headers);
        }

        /// <summary>
        /// Set custom labels for a self-hosted runner for a repository Remove all previous custom labels and set the new custom labels for a specific self-hosted runner configured in a repository.  You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="runnerId">Unique identifier of the self-hosted runner.</param>
        /// <param name="enterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest"></param>
        /// <returns>EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response</returns>
        public EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response ActionsSetCustomLabelsForSelfHostedRunnerForRepo (string owner, string repo, int? runnerId, EnterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest enterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActionsSetCustomLabelsForSelfHostedRunnerForRepo");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActionsSetCustomLabelsForSelfHostedRunnerForRepo");
            
            // verify the required parameter 'runnerId' is set
            if (runnerId == null) throw new ApiException(400, "Missing required parameter 'runnerId' when calling ActionsSetCustomLabelsForSelfHostedRunnerForRepo");
            
            // verify the required parameter 'enterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest' is set
            if (enterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest == null) throw new ApiException(400, "Missing required parameter 'enterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest' when calling ActionsSetCustomLabelsForSelfHostedRunnerForRepo");
            

            var path = "/repos/{owner}/{repo}/actions/runners/{runner_id}/labels";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));
path = path.Replace("{" + "runner_id" + "}", ApiClient.ParameterToString(runnerId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(enterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsSetCustomLabelsForSelfHostedRunnerForRepo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsSetCustomLabelsForSelfHostedRunnerForRepo: " + response.ErrorMessage, response.ErrorMessage);

            return (EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response) ApiClient.Deserialize(response.Content, typeof(EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response), response.Headers);
        }

        /// <summary>
        /// Set the opt-in flag of an OIDC subject claim customization for a repository Sets the &#x60;opt-in&#x60; or &#x60;opt-out&#x60; flag of a GitHub Actions OpenID Connect (OIDC) subject claim customization for a repository. You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;actions:write&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="theJsonPayloadEnablesDisablesTheUseOfSubClaimCustomization"></param>
        /// <returns>Object</returns>
        public Object ActionsSetCustomOidcSubClaimForRepo (string owner, string repo, TheJsonPayloadEnablesDisablesTheUseOfSubClaimCustomization theJsonPayloadEnablesDisablesTheUseOfSubClaimCustomization)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActionsSetCustomOidcSubClaimForRepo");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActionsSetCustomOidcSubClaimForRepo");
            
            // verify the required parameter 'theJsonPayloadEnablesDisablesTheUseOfSubClaimCustomization' is set
            if (theJsonPayloadEnablesDisablesTheUseOfSubClaimCustomization == null) throw new ApiException(400, "Missing required parameter 'theJsonPayloadEnablesDisablesTheUseOfSubClaimCustomization' when calling ActionsSetCustomOidcSubClaimForRepo");
            

            var path = "/repos/{owner}/{repo}/actions/oidc/customization/sub";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(theJsonPayloadEnablesDisablesTheUseOfSubClaimCustomization); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsSetCustomOidcSubClaimForRepo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsSetCustomOidcSubClaimForRepo: " + response.ErrorMessage, response.ErrorMessage);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }

        /// <summary>
        /// Set default workflow permissions for an enterprise Sets the default workflow permissions granted to the &#x60;GITHUB_TOKEN&#x60; when running workflows in an enterprise, and sets whether GitHub Actions can submit approving pull request reviews. For more information, see \&quot;[Enforcing a policy for workflow permissions in your enterprise](https://docs.github.com/enterprise-cloud@latest/admin/policies/enforcing-policies-for-your-enterprise/enforcing-policies-for-github-actions-in-your-enterprise#enforcing-a-policy-for-workflow-permissions-in-your-enterprise).\&quot;  You must authenticate using an access token with the &#x60;admin:enterprise&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;enterprise_administration:write&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="enterprise">The slug version of the enterprise name. You can also substitute this value with the enterprise id.</param>
        /// <param name="actionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest"></param>
        /// <returns></returns>
        public void ActionsSetGithubActionsDefaultWorkflowPermissionsEnterprise (string enterprise, ActionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest actionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest)
        {
            
            // verify the required parameter 'enterprise' is set
            if (enterprise == null) throw new ApiException(400, "Missing required parameter 'enterprise' when calling ActionsSetGithubActionsDefaultWorkflowPermissionsEnterprise");
            
            // verify the required parameter 'actionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest' is set
            if (actionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest == null) throw new ApiException(400, "Missing required parameter 'actionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest' when calling ActionsSetGithubActionsDefaultWorkflowPermissionsEnterprise");
            

            var path = "/enterprises/{enterprise}/actions/permissions/workflow";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "enterprise" + "}", ApiClient.ParameterToString(enterprise));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(actionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsSetGithubActionsDefaultWorkflowPermissionsEnterprise: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsSetGithubActionsDefaultWorkflowPermissionsEnterprise: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Set default workflow permissions for an organization Sets the default workflow permissions granted to the &#x60;GITHUB_TOKEN&#x60; when running workflows in an organization, and sets if GitHub Actions can submit approving pull request reviews. For more information, see \&quot;[Setting the permissions of the GITHUB_TOKEN for your organization](https://docs.github.com/organizations/managing-organization-settings/disabling-or-limiting-github-actions-for-your-organization#setting-the-permissions-of-the-github_token-for-your-organization).\&quot;  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;administration&#x60; organization permission to use this API.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="actionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest"></param>
        /// <returns></returns>
        public void ActionsSetGithubActionsDefaultWorkflowPermissionsOrganization (string org, ActionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest actionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling ActionsSetGithubActionsDefaultWorkflowPermissionsOrganization");
            

            var path = "/orgs/{org}/actions/permissions/workflow";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(actionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsSetGithubActionsDefaultWorkflowPermissionsOrganization: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsSetGithubActionsDefaultWorkflowPermissionsOrganization: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Set default workflow permissions for a repository Sets the default workflow permissions granted to the &#x60;GITHUB_TOKEN&#x60; when running workflows in a repository, and sets if GitHub Actions can submit approving pull request reviews. For more information, see \&quot;[Setting the permissions of the GITHUB_TOKEN for your repository](https://docs.github.com/repositories/managing-your-repositorys-settings-and-features/enabling-features-for-your-repository/managing-github-actions-settings-for-a-repository#setting-the-permissions-of-the-github_token-for-your-repository).\&quot;  You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the repository &#x60;administration&#x60; permission to use this API.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="actionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest"></param>
        /// <returns></returns>
        public void ActionsSetGithubActionsDefaultWorkflowPermissionsRepository (string owner, string repo, ActionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest actionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActionsSetGithubActionsDefaultWorkflowPermissionsRepository");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActionsSetGithubActionsDefaultWorkflowPermissionsRepository");
            
            // verify the required parameter 'actionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest' is set
            if (actionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest == null) throw new ApiException(400, "Missing required parameter 'actionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest' when calling ActionsSetGithubActionsDefaultWorkflowPermissionsRepository");
            

            var path = "/repos/{owner}/{repo}/actions/permissions/workflow";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(actionsSetGithubActionsDefaultWorkflowPermissionsEnterpriseRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsSetGithubActionsDefaultWorkflowPermissionsRepository: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsSetGithubActionsDefaultWorkflowPermissionsRepository: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Set GitHub Actions permissions for an organization Sets the GitHub Actions permissions policy for repositories and allowed actions and reusable workflows in an organization.  If the organization belongs to an enterprise that has set restrictive permissions at the enterprise level, such as &#x60;allowed_actions&#x60; to &#x60;selected&#x60; actions and reusable workflows, then you cannot override them for the organization.  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;administration&#x60; organization permission to use this API.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="actionsSetGithubActionsPermissionsOrganizationRequest"></param>
        /// <returns></returns>
        public void ActionsSetGithubActionsPermissionsOrganization (string org, ActionsSetGithubActionsPermissionsOrganizationRequest actionsSetGithubActionsPermissionsOrganizationRequest)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling ActionsSetGithubActionsPermissionsOrganization");
            
            // verify the required parameter 'actionsSetGithubActionsPermissionsOrganizationRequest' is set
            if (actionsSetGithubActionsPermissionsOrganizationRequest == null) throw new ApiException(400, "Missing required parameter 'actionsSetGithubActionsPermissionsOrganizationRequest' when calling ActionsSetGithubActionsPermissionsOrganization");
            

            var path = "/orgs/{org}/actions/permissions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(actionsSetGithubActionsPermissionsOrganizationRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsSetGithubActionsPermissionsOrganization: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsSetGithubActionsPermissionsOrganization: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Set GitHub Actions permissions for a repository Sets the GitHub Actions permissions policy for enabling GitHub Actions and allowed actions and reusable workflows in the repository.  If the repository belongs to an organization or enterprise that has set restrictive permissions at the organization or enterprise levels, such as &#x60;allowed_actions&#x60; to &#x60;selected&#x60; actions and reusable workflows, then you cannot override them for the repository.  You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;administration&#x60; repository permission to use this API.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="actionsSetGithubActionsPermissionsRepositoryRequest"></param>
        /// <returns></returns>
        public void ActionsSetGithubActionsPermissionsRepository (string owner, string repo, ActionsSetGithubActionsPermissionsRepositoryRequest actionsSetGithubActionsPermissionsRepositoryRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActionsSetGithubActionsPermissionsRepository");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActionsSetGithubActionsPermissionsRepository");
            
            // verify the required parameter 'actionsSetGithubActionsPermissionsRepositoryRequest' is set
            if (actionsSetGithubActionsPermissionsRepositoryRequest == null) throw new ApiException(400, "Missing required parameter 'actionsSetGithubActionsPermissionsRepositoryRequest' when calling ActionsSetGithubActionsPermissionsRepository");
            

            var path = "/repos/{owner}/{repo}/actions/permissions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(actionsSetGithubActionsPermissionsRepositoryRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsSetGithubActionsPermissionsRepository: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsSetGithubActionsPermissionsRepository: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Set repository access for a self-hosted runner group in an organization The self-hosted runner groups REST API is available with GitHub Enterprise Cloud. For more information, see \&quot;[GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products).\&quot;  Replaces the list of repositories that have access to a self-hosted runner group configured in an organization.  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="runnerGroupId">Unique identifier of the self-hosted runner group.</param>
        /// <param name="actionsSetRepoAccessToSelfHostedRunnerGroupInOrgRequest"></param>
        /// <returns></returns>
        public void ActionsSetRepoAccessToSelfHostedRunnerGroupInOrg (string org, int? runnerGroupId, ActionsSetRepoAccessToSelfHostedRunnerGroupInOrgRequest actionsSetRepoAccessToSelfHostedRunnerGroupInOrgRequest)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling ActionsSetRepoAccessToSelfHostedRunnerGroupInOrg");
            
            // verify the required parameter 'runnerGroupId' is set
            if (runnerGroupId == null) throw new ApiException(400, "Missing required parameter 'runnerGroupId' when calling ActionsSetRepoAccessToSelfHostedRunnerGroupInOrg");
            
            // verify the required parameter 'actionsSetRepoAccessToSelfHostedRunnerGroupInOrgRequest' is set
            if (actionsSetRepoAccessToSelfHostedRunnerGroupInOrgRequest == null) throw new ApiException(400, "Missing required parameter 'actionsSetRepoAccessToSelfHostedRunnerGroupInOrgRequest' when calling ActionsSetRepoAccessToSelfHostedRunnerGroupInOrg");
            

            var path = "/orgs/{org}/actions/runner-groups/{runner_group_id}/repositories";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "runner_group_id" + "}", ApiClient.ParameterToString(runnerGroupId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(actionsSetRepoAccessToSelfHostedRunnerGroupInOrgRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsSetRepoAccessToSelfHostedRunnerGroupInOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsSetRepoAccessToSelfHostedRunnerGroupInOrg: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Set selected repositories for an organization secret Replaces all repositories for an organization secret when the &#x60;visibility&#x60; for repository access is set to &#x60;selected&#x60;. The visibility is set when you [Create or update an organization secret](https://docs.github.com/rest/reference/actions#create-or-update-an-organization-secret). You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;secrets&#x60; organization permission to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="secretName">The name of the secret.</param>
        /// <param name="actionsSetSelectedReposForOrgSecretRequest"></param>
        /// <returns></returns>
        public void ActionsSetSelectedReposForOrgSecret (string org, string secretName, ActionsSetSelectedReposForOrgSecretRequest actionsSetSelectedReposForOrgSecretRequest)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling ActionsSetSelectedReposForOrgSecret");
            
            // verify the required parameter 'secretName' is set
            if (secretName == null) throw new ApiException(400, "Missing required parameter 'secretName' when calling ActionsSetSelectedReposForOrgSecret");
            
            // verify the required parameter 'actionsSetSelectedReposForOrgSecretRequest' is set
            if (actionsSetSelectedReposForOrgSecretRequest == null) throw new ApiException(400, "Missing required parameter 'actionsSetSelectedReposForOrgSecretRequest' when calling ActionsSetSelectedReposForOrgSecret");
            

            var path = "/orgs/{org}/actions/secrets/{secret_name}/repositories";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "secret_name" + "}", ApiClient.ParameterToString(secretName));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(actionsSetSelectedReposForOrgSecretRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsSetSelectedReposForOrgSecret: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsSetSelectedReposForOrgSecret: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Set selected repositories enabled for GitHub Actions in an organization Replaces the list of selected repositories that are enabled for GitHub Actions in an organization. To use this endpoint, the organization permission policy for &#x60;enabled_repositories&#x60; must be configured to &#x60;selected&#x60;. For more information, see \&quot;[Set GitHub Actions permissions for an organization](#set-github-actions-permissions-for-an-organization).\&quot;  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint. GitHub Apps must have the &#x60;administration&#x60; organization permission to use this API.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="actionsSetSelectedRepositoriesEnabledGithubActionsOrganizationRequest"></param>
        /// <returns></returns>
        public void ActionsSetSelectedRepositoriesEnabledGithubActionsOrganization (string org, ActionsSetSelectedRepositoriesEnabledGithubActionsOrganizationRequest actionsSetSelectedRepositoriesEnabledGithubActionsOrganizationRequest)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling ActionsSetSelectedRepositoriesEnabledGithubActionsOrganization");
            
            // verify the required parameter 'actionsSetSelectedRepositoriesEnabledGithubActionsOrganizationRequest' is set
            if (actionsSetSelectedRepositoriesEnabledGithubActionsOrganizationRequest == null) throw new ApiException(400, "Missing required parameter 'actionsSetSelectedRepositoriesEnabledGithubActionsOrganizationRequest' when calling ActionsSetSelectedRepositoriesEnabledGithubActionsOrganization");
            

            var path = "/orgs/{org}/actions/permissions/repositories";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(actionsSetSelectedRepositoriesEnabledGithubActionsOrganizationRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsSetSelectedRepositoriesEnabledGithubActionsOrganization: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsSetSelectedRepositoriesEnabledGithubActionsOrganization: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Set self-hosted runners in a group for an organization The self-hosted runner groups REST API is available with GitHub Enterprise Cloud. For more information, see \&quot;[GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products).\&quot;  Replaces the list of self-hosted runners that are part of an organization runner group.  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="runnerGroupId">Unique identifier of the self-hosted runner group.</param>
        /// <param name="enterpriseAdminSetSelfHostedRunnersInGroupForEnterpriseRequest"></param>
        /// <returns></returns>
        public void ActionsSetSelfHostedRunnersInGroupForOrg (string org, int? runnerGroupId, EnterpriseAdminSetSelfHostedRunnersInGroupForEnterpriseRequest enterpriseAdminSetSelfHostedRunnersInGroupForEnterpriseRequest)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling ActionsSetSelfHostedRunnersInGroupForOrg");
            
            // verify the required parameter 'runnerGroupId' is set
            if (runnerGroupId == null) throw new ApiException(400, "Missing required parameter 'runnerGroupId' when calling ActionsSetSelfHostedRunnersInGroupForOrg");
            
            // verify the required parameter 'enterpriseAdminSetSelfHostedRunnersInGroupForEnterpriseRequest' is set
            if (enterpriseAdminSetSelfHostedRunnersInGroupForEnterpriseRequest == null) throw new ApiException(400, "Missing required parameter 'enterpriseAdminSetSelfHostedRunnersInGroupForEnterpriseRequest' when calling ActionsSetSelfHostedRunnersInGroupForOrg");
            

            var path = "/orgs/{org}/actions/runner-groups/{runner_group_id}/runners";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "runner_group_id" + "}", ApiClient.ParameterToString(runnerGroupId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(enterpriseAdminSetSelfHostedRunnersInGroupForEnterpriseRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsSetSelfHostedRunnersInGroupForOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsSetSelfHostedRunnersInGroupForOrg: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Set the level of access for workflows outside of the repository Sets the level of access that workflows outside of the repository have to actions and reusable workflows in the repository. This endpoint only applies to internal repositories. For more information, see \&quot;[Managing GitHub Actions settings for a repository](https://docs.github.com/repositories/managing-your-repositorys-settings-and-features/enabling-features-for-your-repository/managing-github-actions-settings-for-a-repository#allowing-access-to-components-in-an-internal-repository).\&quot;  You must authenticate using an access token with the &#x60;repo&#x60; scope to use this endpoint. GitHub Apps must have the repository &#x60;administration&#x60; permission to use this endpoint.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="actionsGetWorkflowAccessToRepository200Response"></param>
        /// <returns></returns>
        public void ActionsSetWorkflowAccessToRepository (string owner, string repo, ActionsGetWorkflowAccessToRepository200Response actionsGetWorkflowAccessToRepository200Response)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ActionsSetWorkflowAccessToRepository");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ActionsSetWorkflowAccessToRepository");
            
            // verify the required parameter 'actionsGetWorkflowAccessToRepository200Response' is set
            if (actionsGetWorkflowAccessToRepository200Response == null) throw new ApiException(400, "Missing required parameter 'actionsGetWorkflowAccessToRepository200Response' when calling ActionsSetWorkflowAccessToRepository");
            

            var path = "/repos/{owner}/{repo}/actions/permissions/access";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(actionsGetWorkflowAccessToRepository200Response); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsSetWorkflowAccessToRepository: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsSetWorkflowAccessToRepository: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Update a self-hosted runner group for an organization The self-hosted runner groups REST API is available with GitHub Enterprise Cloud. For more information, see \&quot;[GitHub&#39;s products](https://docs.github.com/github/getting-started-with-github/githubs-products).\&quot;  Updates the &#x60;name&#x60; and &#x60;visibility&#x60; of a self-hosted runner group in an organization.  You must authenticate using an access token with the &#x60;admin:org&#x60; scope to use this endpoint.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="runnerGroupId">Unique identifier of the self-hosted runner group.</param>
        /// <param name="actionsUpdateSelfHostedRunnerGroupForOrgRequest"></param>
        /// <returns>ActionsListSelfHostedRunnerGroupsForOrg200ResponseRunnerGroupsInner</returns>
        public ActionsListSelfHostedRunnerGroupsForOrg200ResponseRunnerGroupsInner ActionsUpdateSelfHostedRunnerGroupForOrg (string org, int? runnerGroupId, ActionsUpdateSelfHostedRunnerGroupForOrgRequest actionsUpdateSelfHostedRunnerGroupForOrgRequest)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling ActionsUpdateSelfHostedRunnerGroupForOrg");
            
            // verify the required parameter 'runnerGroupId' is set
            if (runnerGroupId == null) throw new ApiException(400, "Missing required parameter 'runnerGroupId' when calling ActionsUpdateSelfHostedRunnerGroupForOrg");
            
            // verify the required parameter 'actionsUpdateSelfHostedRunnerGroupForOrgRequest' is set
            if (actionsUpdateSelfHostedRunnerGroupForOrgRequest == null) throw new ApiException(400, "Missing required parameter 'actionsUpdateSelfHostedRunnerGroupForOrgRequest' when calling ActionsUpdateSelfHostedRunnerGroupForOrg");
            

            var path = "/orgs/{org}/actions/runner-groups/{runner_group_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "runner_group_id" + "}", ApiClient.ParameterToString(runnerGroupId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(actionsUpdateSelfHostedRunnerGroupForOrgRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsUpdateSelfHostedRunnerGroupForOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionsUpdateSelfHostedRunnerGroupForOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (ActionsListSelfHostedRunnerGroupsForOrg200ResponseRunnerGroupsInner) ApiClient.Deserialize(response.Content, typeof(ActionsListSelfHostedRunnerGroupsForOrg200ResponseRunnerGroupsInner), response.Headers);
        }

    }
}
