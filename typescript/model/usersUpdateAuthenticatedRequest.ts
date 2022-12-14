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

export class UsersUpdateAuthenticatedRequest {
    /**
    * The new name of the user.
    */
    'name'?: string;
    /**
    * The publicly visible email address of the user.
    */
    'email'?: string;
    /**
    * The new blog URL of the user.
    */
    'blog'?: string;
    /**
    * The new Twitter username of the user.
    */
    'twitterUsername'?: string | null;
    /**
    * The new company of the user.
    */
    'company'?: string;
    /**
    * The new location of the user.
    */
    'location'?: string;
    /**
    * The new hiring availability of the user.
    */
    'hireable'?: boolean;
    /**
    * The new short biography of the user.
    */
    'bio'?: string;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "name",
            "baseName": "name",
            "type": "string"
        },
        {
            "name": "email",
            "baseName": "email",
            "type": "string"
        },
        {
            "name": "blog",
            "baseName": "blog",
            "type": "string"
        },
        {
            "name": "twitterUsername",
            "baseName": "twitter_username",
            "type": "string"
        },
        {
            "name": "company",
            "baseName": "company",
            "type": "string"
        },
        {
            "name": "location",
            "baseName": "location",
            "type": "string"
        },
        {
            "name": "hireable",
            "baseName": "hireable",
            "type": "boolean"
        },
        {
            "name": "bio",
            "baseName": "bio",
            "type": "string"
        }    ];

    static getAttributeTypeMap() {
        return UsersUpdateAuthenticatedRequest.attributeTypeMap;
    }
}

