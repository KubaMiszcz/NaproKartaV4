import { ICycle } from './icycle';

export interface IChart {
    id: number;
    title: string;
    note: string;
    cycles: ICycle[];
}

export class Chart implements IChart {
    id: number;
    title: string;
    note: string;
    cycles: ICycle[];
}
