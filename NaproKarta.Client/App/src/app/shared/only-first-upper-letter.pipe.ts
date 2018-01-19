import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'onlyFirstUpperLetter'
})
export class OnlyFirstUpperLetter implements PipeTransform {

  transform(value: string): any {
    if (value !== undefined) {
      return value.slice(0, 1).toUpperCase();
    } else { return ''; }
  }

}
