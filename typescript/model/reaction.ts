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
import { SimpleUser } from './simpleUser';

/**
* Reactions to conversations provide a way to help people express their feelings more simply and effectively.
*/
export class Reaction {
    'id': number;
    'nodeId': string;
    'user': SimpleUser | null;
    /**
    * The reaction to use
    */
    'content': Reaction.ContentEnum;
    'createdAt': Date;

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
            "name": "user",
            "baseName": "user",
            "type": "SimpleUser"
        },
        {
            "name": "content",
            "baseName": "content",
            "type": "Reaction.ContentEnum"
        },
        {
            "name": "createdAt",
            "baseName": "created_at",
            "type": "Date"
        }    ];

    static getAttributeTypeMap() {
        return Reaction.attributeTypeMap;
    }
}

export namespace Reaction {
    export enum ContentEnum {
        _1 = <any> '+1',
        _1 = <any> '-1',
        Laugh = <any> 'laugh',
        Confused = <any> 'confused',
        Heart = <any> 'heart',
        Hooray = <any> 'hooray',
        Rocket = <any> 'rocket',
        Eyes = <any> 'eyes'
    }
}
