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
import { SearchResultTextMatchesInner } from './searchResultTextMatchesInner';
import { TopicSearchResultItemRelatedInner } from './topicSearchResultItemRelatedInner';

/**
* Topic Search Result Item
*/
export class TopicSearchResultItem {
    'name': string;
    'displayName': string | null;
    'shortDescription': string | null;
    'description': string | null;
    'createdBy': string | null;
    'released': string | null;
    'createdAt': Date;
    'updatedAt': Date;
    'featured': boolean;
    'curated': boolean;
    'score': number;
    'repositoryCount'?: number | null;
    'logoUrl'?: string | null;
    'textMatches'?: Array<SearchResultTextMatchesInner>;
    'related'?: Array<TopicSearchResultItemRelatedInner> | null;
    'aliases'?: Array<TopicSearchResultItemRelatedInner> | null;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "name",
            "baseName": "name",
            "type": "string"
        },
        {
            "name": "displayName",
            "baseName": "display_name",
            "type": "string"
        },
        {
            "name": "shortDescription",
            "baseName": "short_description",
            "type": "string"
        },
        {
            "name": "description",
            "baseName": "description",
            "type": "string"
        },
        {
            "name": "createdBy",
            "baseName": "created_by",
            "type": "string"
        },
        {
            "name": "released",
            "baseName": "released",
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
            "name": "featured",
            "baseName": "featured",
            "type": "boolean"
        },
        {
            "name": "curated",
            "baseName": "curated",
            "type": "boolean"
        },
        {
            "name": "score",
            "baseName": "score",
            "type": "number"
        },
        {
            "name": "repositoryCount",
            "baseName": "repository_count",
            "type": "number"
        },
        {
            "name": "logoUrl",
            "baseName": "logo_url",
            "type": "string"
        },
        {
            "name": "textMatches",
            "baseName": "text_matches",
            "type": "Array<SearchResultTextMatchesInner>"
        },
        {
            "name": "related",
            "baseName": "related",
            "type": "Array<TopicSearchResultItemRelatedInner>"
        },
        {
            "name": "aliases",
            "baseName": "aliases",
            "type": "Array<TopicSearchResultItemRelatedInner>"
        }    ];

    static getAttributeTypeMap() {
        return TopicSearchResultItem.attributeTypeMap;
    }
}
