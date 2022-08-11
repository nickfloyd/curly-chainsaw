/**
 * GitHub v3 REST API
 * GitHub\'s v3 REST API.
 *
 * The version of the OpenAPI document: 1.1.4
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import { RequestFile } from './models';

/**
* The type of deployment branch policy for this environment. To allow all branches to deploy, set to `null`.
*/
export class EnvironmentDeploymentBranchPolicy {
    /**
    * Whether only branches with branch protection rules can deploy to this environment. If `protected_branches` is `true`, `custom_branch_policies` must be `false`; if `protected_branches` is `false`, `custom_branch_policies` must be `true`.
    */
    'protectedBranches': boolean;
    /**
    * Whether only branches that match the specified name patterns can deploy to this environment.  If `custom_branch_policies` is `true`, `protected_branches` must be `false`; if `custom_branch_policies` is `false`, `protected_branches` must be `true`.
    */
    'customBranchPolicies': boolean;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "protectedBranches",
            "baseName": "protected_branches",
            "type": "boolean"
        },
        {
            "name": "customBranchPolicies",
            "baseName": "custom_branch_policies",
            "type": "boolean"
        }    ];

    static getAttributeTypeMap() {
        return EnvironmentDeploymentBranchPolicy.attributeTypeMap;
    }
}
