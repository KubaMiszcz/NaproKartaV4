import { INote } from './inote';

export interface IObservation {
    id: number;
    cycleId: number;
    numberInCycle: number;
    marker: string;
    date: string; //Date;
    letter: string;
    isB: boolean;
    numTimes: string;
    cipher: string;
    cipherCd: string;
    comments: any; //????
    notes: INote[];
}

export class Observation implements IObservation {
    id: number;
    cycleId: number;
    numberInCycle: number;
    marker: string;
    date: string; //Date;
    letter: string;
    isB: boolean;
    numTimes: string;
    cipher: string;
    cipherCd: string;
    comments: any; //????
    notes: INote[];
}
