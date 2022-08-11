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
import { SimpleUser1 } from './simpleUser1';

/**
* Simple Repository
*/
export class SimpleRepository {
    /**
    * A unique identifier of the repository.
    */
    'id': number;
    /**
    * The GraphQL identifier of the repository.
    */
    'nodeId': string;
    /**
    * The name of the repository.
    */
    'name': string;
    /**
    * The full, globally unique, name of the repository.
    */
    'fullName': string;
    'owner': SimpleUser1;
    /**
    * Whether the repository is private.
    */
    '_private': boolean;
    /**
    * The URL to view the repository on GitHub.com.
    */
    'htmlUrl': string;
    /**
    * The repository description.
    */
    'description': string | null;
    /**
    * Whether the repository is a fork.
    */
    'fork': boolean;
    /**
    * The URL to get more information about the repository from the GitHub API.
    */
    'url': string;
    /**
    * A template for the API URL to download the repository as an archive.
    */
    'archiveUrl': string;
    /**
    * A template for the API URL to list the available assignees for issues in the repository.
    */
    'assigneesUrl': string;
    /**
    * A template for the API URL to create or retrieve a raw Git blob in the repository.
    */
    'blobsUrl': string;
    /**
    * A template for the API URL to get information about branches in the repository.
    */
    'branchesUrl': string;
    /**
    * A template for the API URL to get information about collaborators of the repository.
    */
    'collaboratorsUrl': string;
    /**
    * A template for the API URL to get information about comments on the repository.
    */
    'commentsUrl': string;
    /**
    * A template for the API URL to get information about commits on the repository.
    */
    'commitsUrl': string;
    /**
    * A template for the API URL to compare two commits or refs.
    */
    'compareUrl': string;
    /**
    * A template for the API URL to get the contents of the repository.
    */
    'contentsUrl': string;
    /**
    * A template for the API URL to list the contributors to the repository.
    */
    'contributorsUrl': string;
    /**
    * The API URL to list the deployments of the repository.
    */
    'deploymentsUrl': string;
    /**
    * The API URL to list the downloads on the repository.
    */
    'downloadsUrl': string;
    /**
    * The API URL to list the events of the repository.
    */
    'eventsUrl': string;
    /**
    * The API URL to list the forks of the repository.
    */
    'forksUrl': string;
    /**
    * A template for the API URL to get information about Git commits of the repository.
    */
    'gitCommitsUrl': string;
    /**
    * A template for the API URL to get information about Git refs of the repository.
    */
    'gitRefsUrl': string;
    /**
    * A template for the API URL to get information about Git tags of the repository.
    */
    'gitTagsUrl': string;
    /**
    * A template for the API URL to get information about issue comments on the repository.
    */
    'issueCommentUrl': string;
    /**
    * A template for the API URL to get information about issue events on the repository.
    */
    'issueEventsUrl': string;
    /**
    * A template for the API URL to get information about issues on the repository.
    */
    'issuesUrl': string;
    /**
    * A template for the API URL to get information about deploy keys on the repository.
    */
    'keysUrl': string;
    /**
    * A template for the API URL to get information about labels of the repository.
    */
    'labelsUrl': string;
    /**
    * The API URL to get information about the languages of the repository.
    */
    'languagesUrl': string;
    /**
    * The API URL to merge branches in the repository.
    */
    'mergesUrl': string;
    /**
    * A template for the API URL to get information about milestones of the repository.
    */
    'milestonesUrl': string;
    /**
    * A template for the API URL to get information about notifications on the repository.
    */
    'notificationsUrl': string;
    /**
    * A template for the API URL to get information about pull requests on the repository.
    */
    'pullsUrl': string;
    /**
    * A template for the API URL to get information about releases on the repository.
    */
    'releasesUrl': string;
    /**
    * The API URL to list the stargazers on the repository.
    */
    'stargazersUrl': string;
    /**
    * A template for the API URL to get information about statuses of a commit.
    */
    'statusesUrl': string;
    /**
    * The API URL to list the subscribers on the repository.
    */
    'subscribersUrl': string;
    /**
    * The API URL to subscribe to notifications for this repository.
    */
    'subscriptionUrl': string;
    /**
    * The API URL to get information about tags on the repository.
    */
    'tagsUrl': string;
    /**
    * The API URL to list the teams on the repository.
    */
    'teamsUrl': string;
    /**
    * A template for the API URL to create or retrieve a raw Git tree of the repository.
    */
    'treesUrl': string;
    /**
    * The API URL to list the hooks on the repository.
    */
    'hooksUrl': string;

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
            "name": "hooksUrl",
            "baseName": "hooks_url",
            "type": "string"
        }    ];

    static getAttributeTypeMap() {
        return SimpleRepository.attributeTypeMap;
    }
}

