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
import { FullRepositoryPermissions } from './fullRepositoryPermissions';
import { LicenseSimple } from './licenseSimple';
import { SearchResultTextMatchesInner } from './searchResultTextMatchesInner';
import { SimpleUser } from './simpleUser';

/**
* Repo Search Result Item
*/
export class RepoSearchResultItem {
    'id': number;
    'nodeId': string;
    'name': string;
    'fullName': string;
    'owner': SimpleUser | null;
    '_private': boolean;
    'htmlUrl': string;
    'description': string | null;
    'fork': boolean;
    'url': string;
    'createdAt': Date;
    'updatedAt': Date;
    'pushedAt': Date;
    'homepage': string | null;
    'size': number;
    'stargazersCount': number;
    'watchersCount': number;
    'language': string | null;
    'forksCount': number;
    'openIssuesCount': number;
    'masterBranch'?: string;
    'defaultBranch': string;
    'score': number;
    'forksUrl': string;
    'keysUrl': string;
    'collaboratorsUrl': string;
    'teamsUrl': string;
    'hooksUrl': string;
    'issueEventsUrl': string;
    'eventsUrl': string;
    'assigneesUrl': string;
    'branchesUrl': string;
    'tagsUrl': string;
    'blobsUrl': string;
    'gitTagsUrl': string;
    'gitRefsUrl': string;
    'treesUrl': string;
    'statusesUrl': string;
    'languagesUrl': string;
    'stargazersUrl': string;
    'contributorsUrl': string;
    'subscribersUrl': string;
    'subscriptionUrl': string;
    'commitsUrl': string;
    'gitCommitsUrl': string;
    'commentsUrl': string;
    'issueCommentUrl': string;
    'contentsUrl': string;
    'compareUrl': string;
    'mergesUrl': string;
    'archiveUrl': string;
    'downloadsUrl': string;
    'issuesUrl': string;
    'pullsUrl': string;
    'milestonesUrl': string;
    'notificationsUrl': string;
    'labelsUrl': string;
    'releasesUrl': string;
    'deploymentsUrl': string;
    'gitUrl': string;
    'sshUrl': string;
    'cloneUrl': string;
    'svnUrl': string;
    'forks': number;
    'openIssues': number;
    'watchers': number;
    'topics'?: Array<string>;
    'mirrorUrl': string | null;
    'hasIssues': boolean;
    'hasProjects': boolean;
    'hasPages': boolean;
    'hasWiki': boolean;
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
    'license': LicenseSimple | null;
    'permissions'?: FullRepositoryPermissions;
    'textMatches'?: Array<SearchResultTextMatchesInner>;
    'tempCloneToken'?: string;
    'allowMergeCommit'?: boolean;
    'allowSquashMerge'?: boolean;
    'allowRebaseMerge'?: boolean;
    'allowAutoMerge'?: boolean;
    'deleteBranchOnMerge'?: boolean;
    'allowForking'?: boolean;
    'isTemplate'?: boolean;

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
            "type": "SimpleUser"
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
            "name": "pushedAt",
            "baseName": "pushed_at",
            "type": "Date"
        },
        {
            "name": "homepage",
            "baseName": "homepage",
            "type": "string"
        },
        {
            "name": "size",
            "baseName": "size",
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
            "name": "openIssuesCount",
            "baseName": "open_issues_count",
            "type": "number"
        },
        {
            "name": "masterBranch",
            "baseName": "master_branch",
            "type": "string"
        },
        {
            "name": "defaultBranch",
            "baseName": "default_branch",
            "type": "string"
        },
        {
            "name": "score",
            "baseName": "score",
            "type": "number"
        },
        {
            "name": "forksUrl",
            "baseName": "forks_url",
            "type": "string"
        },
        {
            "name": "keysUrl",
            "baseName": "keys_url",
            "type": "string"
        },
        {
            "name": "collaboratorsUrl",
            "baseName": "collaborators_url",
            "type": "string"
        },
        {
            "name": "teamsUrl",
            "baseName": "teams_url",
            "type": "string"
        },
        {
            "name": "hooksUrl",
            "baseName": "hooks_url",
            "type": "string"
        },
        {
            "name": "issueEventsUrl",
            "baseName": "issue_events_url",
            "type": "string"
        },
        {
            "name": "eventsUrl",
            "baseName": "events_url",
            "type": "string"
        },
        {
            "name": "assigneesUrl",
            "baseName": "assignees_url",
            "type": "string"
        },
        {
            "name": "branchesUrl",
            "baseName": "branches_url",
            "type": "string"
        },
        {
            "name": "tagsUrl",
            "baseName": "tags_url",
            "type": "string"
        },
        {
            "name": "blobsUrl",
            "baseName": "blobs_url",
            "type": "string"
        },
        {
            "name": "gitTagsUrl",
            "baseName": "git_tags_url",
            "type": "string"
        },
        {
            "name": "gitRefsUrl",
            "baseName": "git_refs_url",
            "type": "string"
        },
        {
            "name": "treesUrl",
            "baseName": "trees_url",
            "type": "string"
        },
        {
            "name": "statusesUrl",
            "baseName": "statuses_url",
            "type": "string"
        },
        {
            "name": "languagesUrl",
            "baseName": "languages_url",
            "type": "string"
        },
        {
            "name": "stargazersUrl",
            "baseName": "stargazers_url",
            "type": "string"
        },
        {
            "name": "contributorsUrl",
            "baseName": "contributors_url",
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
            "name": "commitsUrl",
            "baseName": "commits_url",
            "type": "string"
        },
        {
            "name": "gitCommitsUrl",
            "baseName": "git_commits_url",
            "type": "string"
        },
        {
            "name": "commentsUrl",
            "baseName": "comments_url",
            "type": "string"
        },
        {
            "name": "issueCommentUrl",
            "baseName": "issue_comment_url",
            "type": "string"
        },
        {
            "name": "contentsUrl",
            "baseName": "contents_url",
            "type": "string"
        },
        {
            "name": "compareUrl",
            "baseName": "compare_url",
            "type": "string"
        },
        {
            "name": "mergesUrl",
            "baseName": "merges_url",
            "type": "string"
        },
        {
            "name": "archiveUrl",
            "baseName": "archive_url",
            "type": "string"
        },
        {
            "name": "downloadsUrl",
            "baseName": "downloads_url",
            "type": "string"
        },
        {
            "name": "issuesUrl",
            "baseName": "issues_url",
            "type": "string"
        },
        {
            "name": "pullsUrl",
            "baseName": "pulls_url",
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
            "name": "labelsUrl",
            "baseName": "labels_url",
            "type": "string"
        },
        {
            "name": "releasesUrl",
            "baseName": "releases_url",
            "type": "string"
        },
        {
            "name": "deploymentsUrl",
            "baseName": "deployments_url",
            "type": "string"
        },
        {
            "name": "gitUrl",
            "baseName": "git_url",
            "type": "string"
        },
        {
            "name": "sshUrl",
            "baseName": "ssh_url",
            "type": "string"
        },
        {
            "name": "cloneUrl",
            "baseName": "clone_url",
            "type": "string"
        },
        {
            "name": "svnUrl",
            "baseName": "svn_url",
            "type": "string"
        },
        {
            "name": "forks",
            "baseName": "forks",
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
            "name": "topics",
            "baseName": "topics",
            "type": "Array<string>"
        },
        {
            "name": "mirrorUrl",
            "baseName": "mirror_url",
            "type": "string"
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
            "name": "hasPages",
            "baseName": "has_pages",
            "type": "boolean"
        },
        {
            "name": "hasWiki",
            "baseName": "has_wiki",
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
            "name": "license",
            "baseName": "license",
            "type": "LicenseSimple"
        },
        {
            "name": "permissions",
            "baseName": "permissions",
            "type": "FullRepositoryPermissions"
        },
        {
            "name": "textMatches",
            "baseName": "text_matches",
            "type": "Array<SearchResultTextMatchesInner>"
        },
        {
            "name": "tempCloneToken",
            "baseName": "temp_clone_token",
            "type": "string"
        },
        {
            "name": "allowMergeCommit",
            "baseName": "allow_merge_commit",
            "type": "boolean"
        },
        {
            "name": "allowSquashMerge",
            "baseName": "allow_squash_merge",
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
            "name": "allowForking",
            "baseName": "allow_forking",
            "type": "boolean"
        },
        {
            "name": "isTemplate",
            "baseName": "is_template",
            "type": "boolean"
        }    ];

    static getAttributeTypeMap() {
        return RepoSearchResultItem.attributeTypeMap;
    }
}

