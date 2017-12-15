import { ICycle } from './icycle';

export interface IChart {
    title: string;
    note: string;
    // cycles: ICycle[];
}

export class Chart implements IChart {
    title: string;
    note: string;
    // cycles: ICycle[];
}
