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
import { CodeOfConductSimple } from './codeOfConductSimple';
import { FullRepositoryPermissions } from './fullRepositoryPermissions';
import { FullRepositorySecurityAndAnalysis } from './fullRepositorySecurityAndAnalysis';
import { LicenseSimple } from './licenseSimple';
import { Repository } from './repository';
import { Repository1 } from './repository1';
import { SimpleUser } from './simpleUser';
import { SimpleUser1 } from './simpleUser1';

/**
* Full Repository
*/
export class FullRepository {
    'id': number;
    'nodeId': string;
    'name': string;
    'fullName': string;
    'owner': SimpleUser1;
    '_private': boolean;
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
    'defaultBranch': string;
    'openIssuesCount': number;
    'isTemplate'?: boolean;
    'topics'?: Array<string>;
    'hasIssues': boolean;
    'hasProjects': boolean;
    'hasWiki': boolean;
    'hasPages': boolean;
    'hasDownloads': boolean;
    'archived': boolean;
    /**
    * Returns whether or not this repository disabled.
    */
    'disabled': boolean;
    /**
    * The repository visibility: public, private, or internal.
    */
    'visibility'?: string;
    'pushedAt': Date;
    'createdAt': Date;
    'updatedAt': Date;
    'permissions'?: FullRepositoryPermissions;
    'allowRebaseMerge'?: boolean;
    'templateRepository'?: Repository1 | null;
    'tempCloneToken'?: string | null;
    'allowSquashMerge'?: boolean;
    'allowAutoMerge'?: boolean;
    'deleteBranchOnMerge'?: boolean;
    'allowMergeCommit'?: boolean;
    'allowUpdateBranch'?: boolean;
    'useSquashPrTitleAsDefault'?: boolean;
    'allowForking'?: boolean;
    'subscribersCount': number;
    'networkCount': number;
    'license': LicenseSimple | null;
    'organization'?: SimpleUser | null;
    'parent'?: Repository;
    'source'?: Repository;
    'forks': number;
    'masterBranch'?: string;
    'openIssues': number;
    'watchers': number;
    /**
    * Whether anonymous git access is allowed.
    */
    'anonymousAccessEnabled'?: boolean = true;
    'codeOfConduct'?: CodeOfConductSimple;
    'securityAndAnalysis'?: FullRepositorySecurityAndAnalysis | null;

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
            "name": "permissions",
            "baseName": "permissions",
            "type": "FullRepositoryPermissions"
        },
        {
            "name": "allowRebaseMerge",
            "baseName": "allow_rebase_merge",
            "type": "boolean"
        },
        {
            "name": "templateRepository",
            "baseName": "template_repository",
            "type": "Repository1"
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
            "name": "allowMergeCommit",
            "baseName": "allow_merge_commit",
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
            "name": "parent",
            "baseName": "parent",
            "type": "Repository"
        },
        {
            "name": "source",
            "baseName": "source",
            "type": "Repository"
        },
        {
            "name": "forks",
            "baseName": "forks",
            "type": "number"
        },
        {
            "name": "masterBranch",
            "baseName": "master_branch",
            "type": "string"
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
            "name": "anonymousAccessEnabled",
            "baseName": "anonymous_access_enabled",
            "type": "boolean"
        },
        {
            "name": "codeOfConduct",
            "baseName": "code_of_conduct",
            "type": "CodeOfConductSimple"
        },
        {
            "name": "securityAndAnalysis",
            "baseName": "security_and_analysis",
            "type": "FullRepositorySecurityAndAnalysis"
        }    ];

    static getAttributeTypeMap() {
        return FullRepository.attributeTypeMap;
    }
}

