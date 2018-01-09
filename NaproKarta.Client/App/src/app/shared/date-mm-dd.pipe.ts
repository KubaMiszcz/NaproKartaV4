import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'dateMmDd'
})
export class DateMmDdPipe implements PipeTransform {

  transform(value: Date, args?: any): any {
    if (value !== undefined) {
      return value.toString().slice(5, 10);
    } else { return ''; }
  }

}
