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
import { ChecksCreateRequestOutputAnnotationsInner } from './checksCreateRequestOutputAnnotationsInner';
import { ChecksCreateRequestOutputImagesInner } from './checksCreateRequestOutputImagesInner';

/**
* Check runs can accept a variety of data in the `output` object, including a `title` and `summary` and can optionally provide descriptive details about the run. See the [`output` object](https://docs.github.com/rest/reference/checks#output-object) description.
*/
export class ChecksCreateRequestOutput {
    /**
    * The title of the check run.
    */
    'title': string;
    /**
    * The summary of the check run. This parameter supports Markdown.
    */
    'summary': string;
    /**
    * The details of the check run. This parameter supports Markdown.
    */
    'text'?: string;
    /**
    * Adds information from your analysis to specific lines of code. Annotations are visible on GitHub in the **Checks** and **Files changed** tab of the pull request. The Checks API limits the number of annotations to a maximum of 50 per API request. To create more than 50 annotations, you have to make multiple requests to the [Update a check run](https://docs.github.com/rest/reference/checks#update-a-check-run) endpoint. Each time you update the check run, annotations are appended to the list of annotations that already exist for the check run. For details about how you can view annotations on GitHub, see \"[About status checks](https://docs.github.com/articles/about-status-checks#checks)\". See the [`annotations` object](https://docs.github.com/rest/reference/checks#annotations-object) description for details about how to use this parameter.
    */
    'annotations'?: Array<ChecksCreateRequestOutputAnnotationsInner>;
    /**
    * Adds images to the output displayed in the GitHub pull request UI. See the [`images` object](https://docs.github.com/rest/reference/checks#images-object) description for details.
    */
    'images'?: Array<ChecksCreateRequestOutputImagesInner>;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "title",
            "baseName": "title",
            "type": "string"
        },
        {
            "name": "summary",
            "baseName": "summary",
            "type": "string"
        },
        {
            "name": "text",
            "baseName": "text",
            "type": "string"
        },
        {
            "name": "annotations",
            "baseName": "annotations",
            "type": "Array<ChecksCreateRequestOutputAnnotationsInner>"
        },
        {
            "name": "images",
            "baseName": "images",
            "type": "Array<ChecksCreateRequestOutputImagesInner>"
        }    ];

    static getAttributeTypeMap() {
        return ChecksCreateRequestOutput.attributeTypeMap;
    }
}
