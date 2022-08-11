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
import { ProtectedBranchPullRequestReviewBypassPullRequestAllowances } from './protectedBranchPullRequestReviewBypassPullRequestAllowances';
import { ProtectedBranchPullRequestReviewDismissalRestrictions } from './protectedBranchPullRequestReviewDismissalRestrictions';

/**
* Protected Branch Pull Request Review
*/
export class ProtectedBranchPullRequestReview {
    'url'?: string;
    'dismissalRestrictions'?: ProtectedBranchPullRequestReviewDismissalRestrictions;
    'bypassPullRequestAllowances'?: ProtectedBranchPullRequestReviewBypassPullRequestAllowances;
    'dismissStaleReviews': boolean;
    'requireCodeOwnerReviews': boolean;
    'requiredApprovingReviewCount'?: number;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "url",
            "baseName": "url",
            "type": "string"
        },
        {
            "name": "dismissalRestrictions",
            "baseName": "dismissal_restrictions",
            "type": "ProtectedBranchPullRequestReviewDismissalRestrictions"
        },
        {
            "name": "bypassPullRequestAllowances",
            "baseName": "bypass_pull_request_allowances",
            "type": "ProtectedBranchPullRequestReviewBypassPullRequestAllowances"
        },
        {
            "name": "dismissStaleReviews",
            "baseName": "dismiss_stale_reviews",
            "type": "boolean"
        },
        {
            "name": "requireCodeOwnerReviews",
            "baseName": "require_code_owner_reviews",
            "type": "boolean"
        },
        {
            "name": "requiredApprovingReviewCount",
            "baseName": "required_approving_review_count",
            "type": "number"
        }    ];

    static getAttributeTypeMap() {
        return ProtectedBranchPullRequestReview.attributeTypeMap;
    }
}
