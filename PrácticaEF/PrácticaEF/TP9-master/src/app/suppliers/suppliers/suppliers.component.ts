import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { Suppliers } from 'src/app/Models/SuppliersModel';
import { SuppliersServicesService } from 'src/app/Services/suppliers-service';

@Component({
  selector: 'app-suppliers',
  templateUrl: './suppliers.component.html',
  styleUrls: ['./suppliers.component.css']
})
export class SuppliersComponent implements OnInit {

  listSuppliers: Suppliers[] = [];
  form: FormGroup;
  action = 'ADD';
  id: number | undefined;

  constructor(private fb: FormBuilder,
    private toastr: ToastrService,
    private _supplierService: SuppliersServicesService) {
    this.form = this.fb.group({
      companyName: ['', [Validators.required, Validators.maxLength(40), Validators.minLength(1)]],
      city: ['', [Validators.required, Validators.maxLength(15), Validators.minLength(3)]],
      country: ['', [Validators.required, Validators.maxLength(15), Validators.minLength(2)]],
      phone: ['', [Validators.required, Validators.maxLength(24), Validators.minLength(8)]],
      contactName: ['', [Validators.required, Validators.maxLength(30), Validators.minLength(2)]]
    })
   }

  ngOnInit(): void {
    this.getSuppliers();
  }

  getSuppliers()
  {
    this._supplierService.getListSuppliers().subscribe(data => {
      this.listSuppliers = data;
      }, error => {
        console.log(error);
        this.toastr.warning("Something went wrong, the app is not working.", "Ooops...");
      });
  }

  saveSupplier() {
    const supplier: any = {
      companyName: this.form.get('companyName')?.value,
      city: this.form.get('companyName')?.value,
      country: this.form.get('country')?.value,
      phone: this.form.get('phone')?.value,
      contactName: this.form.get('contactName')?.value
    }
    if(this.id == undefined) {
      this._supplierService.saveSupplier(supplier).subscribe(data => {
        this.toastr.success("The supplier has been added successfully.", "Supplier loaded!!!");
        this.getSuppliers();
        this.form.reset();
      }, error => {
        console.log(error);
        this.toastr.warning("Something went wrong, operation could not be done", "Ooops...");
      });
    }
    else {
        supplier.supplierId = this.id;
        this._supplierService.updateSupplier(this.id, supplier).subscribe(data => {
        this.form.reset();
        this.action ='Add';
        this.id = undefined;
        this.toastr.info("The supplier has been updated successfully.", "Supplier updated!");
        console.log(supplier);
        this.getSuppliers();
        this.form.reset();
      }, error => {
        console.log(error);
        this.toastr.warning("Something went wrong, operation could not be done", "Ooops...");
      });
    }
  }

  deleteSupplier(id: number)
  {
    this._supplierService.deleteSupplier(id).subscribe(data => {
      this.toastr.error("The supplier has been deleted.", "Supplier deleted.");
      this.getSuppliers();
    }, error => {
      console.log(error);
      this.toastr.warning("Something went wrong, operation could not be done", "Ooops...");
    });
  }

  editSupplier(supplier: Suppliers)
  {
    this.action = 'Edit';
    this.id = supplier.supplierId;
    this.form.patchValue({
      companyName: supplier.companyName,
      city: supplier.city,
      country: supplier.country,
      phone: supplier.phone,
      contactName: supplier.contactName
    });
  }
}
