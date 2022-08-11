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
import { Metadata } from './metadata';
import { SnapshotDetector } from './snapshotDetector';
import { SnapshotJob } from './snapshotJob';
import { SnapshotManifestsValue } from './snapshotManifestsValue';

/**
* Create a new snapshot of a repository\'s dependencies.
*/
export class Snapshot {
    /**
    * The version of the repository snapshot submission.
    */
    'version': number;
    'job': SnapshotJob;
    /**
    * The commit SHA associated with this dependency snapshot.
    */
    'sha': string;
    /**
    * The repository branch that triggered this snapshot.
    */
    'ref': string;
    'detector': SnapshotDetector;
    /**
    * User-defined metadata to store domain-specific information limited to 8 keys with scalar values.
    */
    'metadata'?: { [key: string]: Metadata; };
    /**
    * A collection of package manifests
    */
    'manifests'?: { [key: string]: SnapshotManifestsValue; };
    /**
    * The time at which the snapshot was scanned.
    */
    'scanned': Date;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "version",
            "baseName": "version",
            "type": "number"
        },
        {
            "name": "job",
            "baseName": "job",
            "type": "SnapshotJob"
        },
        {
            "name": "sha",
            "baseName": "sha",
            "type": "string"
        },
        {
            "name": "ref",
            "baseName": "ref",
            "type": "string"
        },
        {
            "name": "detector",
            "baseName": "detector",
            "type": "SnapshotDetector"
        },
        {
            "name": "metadata",
            "baseName": "metadata",
            "type": "{ [key: string]: Metadata; }"
        },
        {
            "name": "manifests",
            "baseName": "manifests",
            "type": "{ [key: string]: SnapshotManifestsValue; }"
        },
        {
            "name": "scanned",
            "baseName": "scanned",
            "type": "Date"
        }    ];

    static getAttributeTypeMap() {
        return Snapshot.attributeTypeMap;
    }
}

