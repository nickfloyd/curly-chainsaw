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

export class ReposCreateInOrgRequest {
    /**
    * The name of the repository.
    */
    'name': string;
    /**
    * A short description of the repository.
    */
    'description'?: string;
    /**
    * A URL with more information about the repository.
    */
    'homepage'?: string;
    /**
    * Whether the repository is private.
    */
    '_private'?: boolean = false;
    /**
    * Can be `public` or `private`. If your organization is associated with an enterprise account using GitHub Enterprise Cloud or GitHub Enterprise Server 2.20+, `visibility` can also be `internal`. Note: For GitHub Enterprise Server and GitHub AE, this endpoint will only list repositories available to all users on the enterprise. For more information, see \"[Creating an internal repository](https://docs.github.com/en/github/creating-cloning-and-archiving-repositories/about-repository-visibility#about-internal-repositories)\" in the GitHub Help documentation.
    */
    'visibility'?: ReposCreateInOrgRequest.VisibilityEnum;
    /**
    * Either `true` to enable issues for this repository or `false` to disable them.
    */
    'hasIssues'?: boolean = true;
    /**
    * Either `true` to enable projects for this repository or `false` to disable them. **Note:** If you\'re creating a repository in an organization that has disabled repository projects, the default is `false`, and if you pass `true`, the API returns an error.
    */
    'hasProjects'?: boolean = true;
    /**
    * Either `true` to enable the wiki for this repository or `false` to disable it.
    */
    'hasWiki'?: boolean = true;
    /**
    * Either `true` to make this repo available as a template repository or `false` to prevent it.
    */
    'isTemplate'?: boolean = false;
    /**
    * The id of the team that will be granted access to this repository. This is only valid when creating a repository in an organization.
    */
    'teamId'?: number;
    /**
    * Pass `true` to create an initial commit with empty README.
    */
    'autoInit'?: boolean = false;
    /**
    * Desired language or platform [.gitignore template](https://github.com/github/gitignore) to apply. Use the name of the template without the extension. For example, \"Haskell\".
    */
    'gitignoreTemplate'?: string;
    /**
    * Choose an [open source license template](https://choosealicense.com/) that best suits your needs, and then use the [license keyword](https://docs.github.com/articles/licensing-a-repository/#searching-github-by-license-type) as the `license_template` string. For example, \"mit\" or \"mpl-2.0\".
    */
    'licenseTemplate'?: string;
    /**
    * Either `true` to allow squash-merging pull requests, or `false` to prevent squash-merging.
    */
    'allowSquashMerge'?: boolean = true;
    /**
    * Either `true` to allow merging pull requests with a merge commit, or `false` to prevent merging pull requests with merge commits.
    */
    'allowMergeCommit'?: boolean = true;
    /**
    * Either `true` to allow rebase-merging pull requests, or `false` to prevent rebase-merging.
    */
    'allowRebaseMerge'?: boolean = true;
    /**
    * Either `true` to allow auto-merge on pull requests, or `false` to disallow auto-merge.
    */
    'allowAutoMerge'?: boolean = false;
    /**
    * Either `true` to allow automatically deleting head branches when pull requests are merged, or `false` to prevent automatic deletion.
    */
    'deleteBranchOnMerge'?: boolean = false;
    /**
    * Either `true` to allow squash-merge commits to use pull request title, or `false` to use commit message.
    */
    'useSquashPrTitleAsDefault'?: boolean = false;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "name",
            "baseName": "name",
            "type": "string"
        },
        {
            "name": "description",
            "baseName": "description",
            "type": "string"
        },
        {
            "name": "homepage",
            "baseName": "homepage",
            "type": "string"
        },
        {
            "name": "_private",
            "baseName": "private",
            "type": "boolean"
        },
        {
            "name": "visibility",
            "baseName": "visibility",
            "type": "ReposCreateInOrgRequest.VisibilityEnum"
        },
        {
            "name": "hasIssues",
            "baseName": "has_issues",
            "type": "boolean"
        },
        {
            "name": "hasProjects",
            "baseName": "has_projects",
            "type": "boolean"
        },
        {
            "name": "hasWiki",
            "baseName": "has_wiki",
            "type": "boolean"
        },
        {
            "name": "isTemplate",
            "baseName": "is_template",
            "type": "boolean"
        },
        {
            "name": "teamId",
            "baseName": "team_id",
            "type": "number"
        },
        {
            "name": "autoInit",
            "baseName": "auto_init",
            "type": "boolean"
        },
        {
            "name": "gitignoreTemplate",
            "baseName": "gitignore_template",
            "type": "string"
        },
        {
            "name": "licenseTemplate",
            "baseName": "license_template",
            "type": "string"
        },
        {
            "name": "allowSquashMerge",
            "baseName": "allow_squash_merge",
            "type": "boolean"
        },
        {
            "name": "allowMergeCommit",
            "baseName": "allow_merge_commit",
            "type": "boolean"
        },
        {
            "name": "allowRebaseMerge",
            "baseName": "allow_rebase_merge",
            "type": "boolean"
        },
        {
            "name": "allowAutoMerge",
            "baseName": "allow_auto_merge",
            "type": "boolean"
        },
        {
            "name": "deleteBranchOnMerge",
            "baseName": "delete_branch_on_merge",
            "type": "boolean"
        },
        {
            "name": "useSquashPrTitleAsDefault",
            "baseName": "use_squash_pr_title_as_default",
            "type": "boolean"
        }    ];

    static getAttributeTypeMap() {
        return ReposCreateInOrgRequest.attributeTypeMap;
    }
}

export namespace ReposCreateInOrgRequest {
    export enum VisibilityEnum {
        Public = <any> 'public',
        Private = <any> 'private',
        Internal = <any> 'internal'
    }
}
