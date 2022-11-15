/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
import type { PokemonStatus } from '../models/PokemonStatus';

import type { CancelablePromise } from '../core/CancelablePromise';
import { OpenAPI } from '../core/OpenAPI';
import { request as __request } from '../core/request';

export class PokemonDescriptionService {

    /**
     * @param filter 
     * @returns PokemonStatus Success
     * @throws ApiError
     */
    public static getApiPokemonDescription(
filter?: number,
): CancelablePromise<PokemonStatus> {
        return __request(OpenAPI, {
            method: 'GET',
            url: '/Api/PokemonDescription',
            query: {
                'filter': filter,
            },
            errors: {
                400: `Bad Request`,
            },
        });
    }

}
