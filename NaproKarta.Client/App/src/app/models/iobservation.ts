import { INote } from './inote';

export interface IObservation {
    row: number;
    col: number;
    marker: string;
    markerUrl: string;
    markerTxt: string;
    letter: string;
    cipher: string;
    cipherCd: string;
    comment: string[];
    notes: INote[];
}

export class Observation implements IObservation {
    row: number;
    col: number;
    marker: string;
    markerUrl: string;
    markerTxt: string;
    letter: string;
    cipher: string;
    cipherCd: string;
    comment: string[];
    notes: INote[];
}
