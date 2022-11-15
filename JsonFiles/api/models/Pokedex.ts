/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

import type { PokeShortDescription } from './PokeShortDescription';

export type Pokedex = {
    count?: number;
    next?: string | null;
    previous?: string | null;
    results?: Array<PokeShortDescription> | null;
};
