import { INote } from './inote';

export interface IObservation {
    markerUrl: string;
    markerTxt: string;
    letter: string;
    cipher: string;
    cipherCd: string;
    comment: string[];
    notes: INote[];
}
