/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
import type { Pokedex } from '../models/Pokedex';

import type { CancelablePromise } from '../core/CancelablePromise';
import { OpenAPI } from '../core/OpenAPI';
import { request as __request } from '../core/request';

export class PokeService {

    /**
     * @returns Pokedex Success
     * @throws ApiError
     */
    public static getApiPoke(): CancelablePromise<Pokedex> {
        return __request(OpenAPI, {
            method: 'GET',
            url: '/Api/Poke',
            errors: {
                400: `Bad Request`,
            },
        });
    }

}
