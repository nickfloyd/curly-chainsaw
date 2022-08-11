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
import { LicenseSimple } from './licenseSimple';
import { RepositoryPermissions } from './repositoryPermissions';
import { RepositoryTemplateRepository } from './repositoryTemplateRepository';
import { SimpleUser } from './simpleUser';
import { SimpleUser1 } from './simpleUser1';

/**
* A git repository
*/
export class Repository1 {
    /**
    * Unique identifier of the repository
    */
    'id': number;
    'nodeId': string;
    /**
    * The name of the repository.
    */
    'name': string;
    'fullName': string;
    'license': LicenseSimple | null;
    'organization'?: SimpleUser | null;
    'forks': number;
    'permissions'?: RepositoryPermissions;
    'owner': SimpleUser1;
    /**
    * Whether the repository is private or public.
    */
    '_private': boolean = false;
    'htmlUrl': string;
    'description': string | null;
    'fork': boolean;
    'url': string;
    'archiveUrl': string;
    'assigneesUrl': string;
    'blobsUrl': string;
    'branchesUrl': string;
    'collaboratorsUrl': string;
    'commentsUrl': string;
    'commitsUrl': string;
    'compareUrl': string;
    'contentsUrl': string;
    'contributorsUrl': string;
    'deploymentsUrl': string;
    'downloadsUrl': string;
    'eventsUrl': string;
    'forksUrl': string;
    'gitCommitsUrl': string;
    'gitRefsUrl': string;
    'gitTagsUrl': string;
    'gitUrl': string;
    'issueCommentUrl': string;
    'issueEventsUrl': string;
    'issuesUrl': string;
    'keysUrl': string;
    'labelsUrl': string;
    'languagesUrl': string;
    'mergesUrl': string;
    'milestonesUrl': string;
    'notificationsUrl': string;
    'pullsUrl': string;
    'releasesUrl': string;
    'sshUrl': string;
    'stargazersUrl': string;
    'statusesUrl': string;
    'subscribersUrl': string;
    'subscriptionUrl': string;
    'tagsUrl': string;
    'teamsUrl': string;
    'treesUrl': string;
    'cloneUrl': string;
    'mirrorUrl': string | null;
    'hooksUrl': string;
    'svnUrl': string;
    'homepage': string | null;
    'language': string | null;
    'forksCount': number;
    'stargazersCount': number;
    'watchersCount': number;
    'size': number;
    /**
    * The default branch of the repository.
    */
    'defaultBranch': string;
    'openIssuesCount': number;
    /**
    * Whether this repository acts as a template that can be used to generate new repositories.
    */
    'isTemplate'?: boolean = false;
    'topics'?: Array<string>;
    /**
    * Whether issues are enabled.
    */
    'hasIssues': boolean = true;
    /**
    * Whether projects are enabled.
    */
    'hasProjects': boolean = true;
    /**
    * Whether the wiki is enabled.
    */
    'hasWiki': boolean = true;
    'hasPages': boolean;
    /**
    * Whether downloads are enabled.
    */
    'hasDownloads': boolean = true;
    /**
    * Whether the repository is archived.
    */
    'archived': boolean = false;
    /**
    * Returns whether or not this repository disabled.
    */
    'disabled': boolean;
    /**
    * The repository visibility: public, private, or internal.
    */
    'visibility'?: string = 'public';
    'pushedAt': Date | null;
    'createdAt': Date | null;
    'updatedAt': Date | null;
    /**
    * Whether to allow rebase merges for pull requests.
    */
    'allowRebaseMerge'?: boolean = true;
    'templateRepository'?: RepositoryTemplateRepository | null;
    'tempCloneToken'?: string;
    /**
    * Whether to allow squash merges for pull requests.
    */
    'allowSquashMerge'?: boolean = true;
    /**
    * Whether to allow Auto-merge to be used on pull requests.
    */
    'allowAutoMerge'?: boolean = false;
    /**
    * Whether to delete head branches when pull requests are merged
    */
    'deleteBranchOnMerge'?: boolean = false;
    /**
    * Whether or not a pull request head branch that is behind its base branch can always be updated even if it is not required to be up to date before merging.
    */
    'allowUpdateBranch'?: boolean = false;
    /**
    * Whether a squash merge commit can use the pull request title as default.
    */
    'useSquashPrTitleAsDefault'?: boolean = false;
    /**
    * Whether to allow merge commits for pull requests.
    */
    'allowMergeCommit'?: boolean = true;
    /**
    * Whether to allow forking this repo
    */
    'allowForking'?: boolean;
    'subscribersCount'?: number;
    'networkCount'?: number;
    'openIssues': number;
    'watchers': number;
    'masterBranch'?: string;
    'starredAt'?: string;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "id",
            "baseName": "id",
            "type": "number"
        },
        {
            "name": "nodeId",
            "baseName": "node_id",
            "type": "string"
        },
        {
            "name": "name",
            "baseName": "name",
            "type": "string"
        },
        {
            "name": "fullName",
            "baseName": "full_name",
            "type": "string"
        },
        {
            "name": "license",
            "baseName": "license",
            "type": "LicenseSimple"
        },
        {
            "name": "organization",
            "baseName": "organization",
            "type": "SimpleUser"
        },
        {
            "name": "forks",
            "baseName": "forks",
            "type": "number"
        },
        {
            "name": "permissions",
            "baseName": "permissions",
            "type": "RepositoryPermissions"
        },
        {
            "name": "owner",
            "baseName": "owner",
            "type": "SimpleUser1"
        },
        {
            "name": "_private",
            "baseName": "private",
            "type": "boolean"
        },
        {
            "name": "htmlUrl",
            "baseName": "html_url",
            "type": "string"
        },
        {
            "name": "description",
            "baseName": "description",
            "type": "string"
        },
        {
            "name": "fork",
            "baseName": "fork",
            "type": "boolean"
        },
        {
            "name": "url",
            "baseName": "url",
            "type": "string"
        },
        {
            "name": "archiveUrl",
            "baseName": "archive_url",
            "type": "string"
        },
        {
            "name": "assigneesUrl",
            "baseName": "assignees_url",
            "type": "string"
        },
        {
            "name": "blobsUrl",
            "baseName": "blobs_url",
            "type": "string"
        },
        {
            "name": "branchesUrl",
            "baseName": "branches_url",
            "type": "string"
        },
        {
            "name": "collaboratorsUrl",
            "baseName": "collaborators_url",
            "type": "string"
        },
        {
            "name": "commentsUrl",
            "baseName": "comments_url",
            "type": "string"
        },
        {
            "name": "commitsUrl",
            "baseName": "commits_url",
            "type": "string"
        },
        {
            "name": "compareUrl",
            "baseName": "compare_url",
            "type": "string"
        },
        {
            "name": "contentsUrl",
            "baseName": "contents_url",
            "type": "string"
        },
        {
            "name": "contributorsUrl",
            "baseName": "contributors_url",
            "type": "string"
        },
        {
            "name": "deploymentsUrl",
            "baseName": "deployments_url",
            "type": "string"
        },
        {
            "name": "downloadsUrl",
            "baseName": "downloads_url",
            "type": "string"
        },
        {
            "name": "eventsUrl",
            "baseName": "events_url",
            "type": "string"
        },
        {
            "name": "forksUrl",
            "baseName": "forks_url",
            "type": "string"
        },
        {
            "name": "gitCommitsUrl",
            "baseName": "git_commits_url",
            "type": "string"
        },
        {
            "name": "gitRefsUrl",
            "baseName": "git_refs_url",
            "type": "string"
        },
        {
            "name": "gitTagsUrl",
            "baseName": "git_tags_url",
            "type": "string"
        },
        {
            "name": "gitUrl",
            "baseName": "git_url",
            "type": "string"
        },
        {
            "name": "issueCommentUrl",
            "baseName": "issue_comment_url",
            "type": "string"
        },
        {
            "name": "issueEventsUrl",
            "baseName": "issue_events_url",
            "type": "string"
        },
        {
            "name": "issuesUrl",
            "baseName": "issues_url",
            "type": "string"
        },
        {
            "name": "keysUrl",
            "baseName": "keys_url",
            "type": "string"
        },
        {
            "name": "labelsUrl",
            "baseName": "labels_url",
            "type": "string"
        },
        {
            "name": "languagesUrl",
            "baseName": "languages_url",
            "type": "string"
        },
        {
            "name": "mergesUrl",
            "baseName": "merges_url",
            "type": "string"
        },
        {
            "name": "milestonesUrl",
            "baseName": "milestones_url",
            "type": "string"
        },
        {
            "name": "notificationsUrl",
            "baseName": "notifications_url",
            "type": "string"
        },
        {
            "name": "pullsUrl",
            "baseName": "pulls_url",
            "type": "string"
        },
        {
            "name": "releasesUrl",
            "baseName": "releases_url",
            "type": "string"
        },
        {
            "name": "sshUrl",
            "baseName": "ssh_url",
            "type": "string"
        },
        {
            "name": "stargazersUrl",
            "baseName": "stargazers_url",
            "type": "string"
        },
        {
            "name": "statusesUrl",
            "baseName": "statuses_url",
            "type": "string"
        },
        {
            "name": "subscribersUrl",
            "baseName": "subscribers_url",
            "type": "string"
        },
        {
            "name": "subscriptionUrl",
            "baseName": "subscription_url",
            "type": "string"
        },
        {
            "name": "tagsUrl",
            "baseName": "tags_url",
            "type": "string"
        },
        {
            "name": "teamsUrl",
            "baseName": "teams_url",
            "type": "string"
        },
        {
            "name": "treesUrl",
            "baseName": "trees_url",
            "type": "string"
        },
        {
            "name": "cloneUrl",
            "baseName": "clone_url",
            "type": "string"
        },
        {
            "name": "mirrorUrl",
            "baseName": "mirror_url",
            "type": "string"
        },
        {
            "name": "hooksUrl",
            "baseName": "hooks_url",
            "type": "string"
        },
        {
            "name": "svnUrl",
            "baseName": "svn_url",
            "type": "string"
        },
        {
            "name": "homepage",
            "baseName": "homepage",
            "type": "string"
        },
        {
            "name": "language",
            "baseName": "language",
            "type": "string"
        },
        {
            "name": "forksCount",
            "baseName": "forks_count",
            "type": "number"
        },
        {
            "name": "stargazersCount",
            "baseName": "stargazers_count",
            "type": "number"
        },
        {
            "name": "watchersCount",
            "baseName": "watchers_count",
            "type": "number"
        },
        {
            "name": "size",
            "baseName": "size",
            "type": "number"
        },
        {
            "name": "defaultBranch",
            "baseName": "default_branch",
            "type": "string"
        },
        {
            "name": "openIssuesCount",
            "baseName": "open_issues_count",
            "type": "number"
        },
        {
            "name": "isTemplate",
            "baseName": "is_template",
            "type": "boolean"
        },
        {
            "name": "topics",
            "baseName": "topics",
            "type": "Array<string>"
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
            "name": "hasPages",
            "baseName": "has_pages",
            "type": "boolean"
        },
        {
            "name": "hasDownloads",
            "baseName": "has_downloads",
            "type": "boolean"
        },
        {
            "name": "archived",
            "baseName": "archived",
            "type": "boolean"
        },
        {
            "name": "disabled",
            "baseName": "disabled",
            "type": "boolean"
        },
        {
            "name": "visibility",
            "baseName": "visibility",
            "type": "string"
        },
        {
            "name": "pushedAt",
            "baseName": "pushed_at",
            "type": "Date"
        },
        {
            "name": "createdAt",
            "baseName": "created_at",
            "type": "Date"
        },
        {
            "name": "updatedAt",
            "baseName": "updated_at",
            "type": "Date"
        },
        {
            "name": "allowRebaseMerge",
            "baseName": "allow_rebase_merge",
            "type": "boolean"
        },
        {
            "name": "templateRepository",
            "baseName": "template_repository",
            "type": "RepositoryTemplateRepository"
        },
        {
            "name": "tempCloneToken",
            "baseName": "temp_clone_token",
            "type": "string"
        },
        {
            "name": "allowSquashMerge",
            "baseName": "allow_squash_merge",
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
            "name": "allowUpdateBranch",
            "baseName": "allow_update_branch",
            "type": "boolean"
        },
        {
            "name": "useSquashPrTitleAsDefault",
            "baseName": "use_squash_pr_title_as_default",
            "type": "boolean"
        },
        {
            "name": "allowMergeCommit",
            "baseName": "allow_merge_commit",
            "type": "boolean"
        },
        {
            "name": "allowForking",
            "baseName": "allow_forking",
            "type": "boolean"
        },
        {
            "name": "subscribersCount",
            "baseName": "subscribers_count",
            "type": "number"
        },
        {
            "name": "networkCount",
            "baseName": "network_count",
            "type": "number"
        },
        {
            "name": "openIssues",
            "baseName": "open_issues",
            "type": "number"
        },
        {
            "name": "watchers",
            "baseName": "watchers",
            "type": "number"
        },
        {
            "name": "masterBranch",
            "baseName": "master_branch",
            "type": "string"
        },
        {
            "name": "starredAt",
            "baseName": "starred_at",
            "type": "string"
        }    ];

    static getAttributeTypeMap() {
        return Repository1.attributeTypeMap;
    }
}

