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

export class ReposUpdateReleaseRequest {
    /**
    * The name of the tag.
    */
    'tagName'?: string;
    /**
    * Specifies the commitish value that determines where the Git tag is created from. Can be any branch or commit SHA. Unused if the Git tag already exists. Default: the repository\'s default branch (usually `master`).
    */
    'targetCommitish'?: string;
    /**
    * The name of the release.
    */
    'name'?: string;
    /**
    * Text describing the contents of the tag.
    */
    'body'?: string;
    /**
    * `true` makes the release a draft, and `false` publishes the release.
    */
    'draft'?: boolean;
    /**
    * `true` to identify the release as a prerelease, `false` to identify the release as a full release.
    */
    'prerelease'?: boolean;
    /**
    * If specified, a discussion of the specified category is created and linked to the release. The value must be a category that already exists in the repository. If there is already a discussion linked to the release, this parameter is ignored. For more information, see \"[Managing categories for discussions in your repository](https://docs.github.com/discussions/managing-discussions-for-your-community/managing-categories-for-discussions-in-your-repository).\"
    */
    'discussionCategoryName'?: string;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "tagName",
            "baseName": "tag_name",
            "type": "string"
        },
        {
            "name": "targetCommitish",
            "baseName": "target_commitish",
            "type": "string"
        },
        {
            "name": "name",
            "baseName": "name",
            "type": "string"
        },
        {
            "name": "body",
            "baseName": "body",
            "type": "string"
        },
        {
            "name": "draft",
            "baseName": "draft",
            "type": "boolean"
        },
        {
            "name": "prerelease",
            "baseName": "prerelease",
            "type": "boolean"
        },
        {
            "name": "discussionCategoryName",
            "baseName": "discussion_category_name",
            "type": "string"
        }    ];

    static getAttributeTypeMap() {
        return ReposUpdateReleaseRequest.attributeTypeMap;
    }
}
