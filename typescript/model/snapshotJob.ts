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

export class SnapshotJob {
    /**
    * The external ID of the job.
    */
    'id': string;
    /**
    * Correlator provides a key that is used to group snapshots submitted over time. Only the \"latest\" submitted snapshot for a given combination of `job.correlator` and `detector.name` will be considered when calculating a repository\'s current dependencies. Correlator should be as unique as it takes to distinguish all detection runs for a given \"wave\" of CI workflow you run. If you\'re using GitHub Actions, a good default value for this could be the environment variables GITHUB_WORKFLOW and GITHUB_JOB concatenated together. If you\'re using a build matrix, then you\'ll also need to add additional key(s) to distinguish between each submission inside a matrix variation.
    */
    'correlator': string;
    /**
    * The url for the job.
    */
    'htmlUrl'?: string;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "id",
            "baseName": "id",
            "type": "string"
        },
        {
            "name": "correlator",
            "baseName": "correlator",
            "type": "string"
        },
        {
            "name": "htmlUrl",
            "baseName": "html_url",
            "type": "string"
        }    ];

    static getAttributeTypeMap() {
        return SnapshotJob.attributeTypeMap;
    }
}

