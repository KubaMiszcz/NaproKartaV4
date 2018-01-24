export interface INote {
  id: number;
  content: string;
  isImportant: boolean;
}

export class Note implements INote {
  id: number;
  content: string;
  isImportant: boolean;
}
