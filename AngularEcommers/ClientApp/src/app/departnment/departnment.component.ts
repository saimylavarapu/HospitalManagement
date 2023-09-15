import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { AddDepartnemtDTO, DepartnmentClient, GetAllDepartnmentDTO } from '../apiservecs.service';

@Component({
  selector: 'app-departnment',
  templateUrl: './departnment.component.html',
  styleUrls: ['./departnment.component.css'],
  providers: [DepartnmentClient]
})
export class DepartnmentComponent implements OnInit {
  departnemt: GetAllDepartnmentDTO[] = [];
  adddepartnment!: AddDepartnemtDTO;

  constructor(private service: DepartnmentClient, private route: ActivatedRoute,
    private router: Router) { }

  ngOnInit(): void {
    this.getalldep()
  }

  getalldep() {
    debugger
    this.service.getAllDepartnment().subscribe((res) => {
      this.departnemt = res;
      console.log(res);
    })
  }

}
