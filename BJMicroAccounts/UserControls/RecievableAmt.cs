﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BJMicroAccounts.Data;
using MicroAccounts.ViewModel;
using MicroAccounts.AccountsModuleClasses;

namespace MicroAccounts.UserControls
{
    public partial class RecievableAmt : UserControl
    {
        public RecievableAmt()
        {
            InitializeComponent();
        }
        AmtFormatting amtFormat = new AmtFormatting();
        MicroAccountsEntities1 _entities;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalRows_Click(object sender, EventArgs e)
        {

        }
        private void ledgerNameAutoComplete()
        {
            _entities = new MicroAccountsEntities1();

            var gId = _entities.tbl_AccGroup.Where(x => x.groupName == "Sundry Debtors").FirstOrDefault().groupId;

            var ledgerNameAutoComplete = _entities.tbl_AccLedger.Where(x => x.groupId == gId);
            txtLedgerName.AutoCompleteCustomSource.Clear();
            foreach (var item in ledgerNameAutoComplete)
            {
                txtLedgerName.AutoCompleteCustomSource.Add(item.ledgerName.ToString());
            }
        }
        private void RecievableAmt_Load(object sender, EventArgs e)
        {
            ledgerNameAutoComplete();
            datagridBind();
        }

        private void datagridBind()
        {
            try
            {
                dgReceivableAmt.AutoGenerateColumns = false;
                int rowNo = 1;
                _entities = new MicroAccountsEntities1();

                var data = _entities.tbl_AccLedger.Where(x => x.tbl_AccGroup.groupName == "Sundry Debtors").ToList();

                List<LedgerDetailsVM> modelList = new List<LedgerDetailsVM>();
                decimal ttlAmt = 0;
                foreach (var item in data)
                {
                    LedgerDetailsVM model = new LedgerDetailsVM();

                    CrDrDifference crdrDiff = new CrDrDifference();
                    string valueAmt = crdrDiff.DifferenceCrDr(Convert.ToInt32(item.Id), 0);

                    string valueAmtDR = valueAmt.Substring(0, 2);

                    if (valueAmtDR == "Dr")
                    {
                        string pAmtString = valueAmt.Substring(3);

                        model.rowNo = rowNo;
                        model.id = item.Id;
                        model.ledgerName = item.ledgerName.ToString();
                        model.pendingAmt = Convert.ToDecimal(amtFormat.comma(Convert.ToDecimal(pAmtString)));

                        rowNo++;
                        modelList.Add(model);

                        ttlAmt += Convert.ToDecimal(pAmtString);
                        lblTotalAmt.Text = amtFormat.comma(ttlAmt).ToString();
                    }

                }
                dgReceivableAmt.DataSource = modelList;

                lblTotalRows.Text = modelList.Count.ToString();
            }
            catch (Exception x)
            {

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLedgerName.Text = "";
            datagridBind();
        }

        private void txtLedgerName_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                dgReceivableAmt.AutoGenerateColumns = false;
                int rowNo = 1;
                _entities = new MicroAccountsEntities1();

                List<tbl_AccLedger> data = new List<tbl_AccLedger>();

                if (txtLedgerName.Text == "")
                {
                    data = _entities.tbl_AccLedger.Where(x => x.tbl_AccGroup.groupName == "Sundry Debtors").ToList();
                }
                else
                {
                    data = _entities.tbl_AccLedger.Where(x => x.tbl_AccGroup.groupName == "Sundry Debtors" && x.ledgerName.Contains(txtLedgerName.Text.ToString())).ToList();
                }


                List<LedgerDetailsVM> modelList = new List<LedgerDetailsVM>();
                decimal ttlAmt = 0;
                foreach (var item in data)
                {
                    LedgerDetailsVM model = new LedgerDetailsVM();

                    CrDrDifference crdrDiff = new CrDrDifference();
                    string valueAmt = crdrDiff.DifferenceCrDr(Convert.ToInt32(item.Id), 0);

                    string valueAmtDR = valueAmt.Substring(0, 2);


                    if (valueAmtDR == "Dr")
                    {
                        string pAmtString = valueAmt.Substring(3);

                        model.rowNo = rowNo;
                        model.id = item.Id;
                        model.ledgerName = item.ledgerName.ToString();
                        model.pendingAmt = Convert.ToDecimal(amtFormat.comma(Convert.ToDecimal(pAmtString)));

                        rowNo++;
                        modelList.Add(model);

                        ttlAmt += Convert.ToDecimal(pAmtString);
                        lblTotalAmt.Text = amtFormat.comma(ttlAmt).ToString();
                    }

                }
                dgReceivableAmt.DataSource = modelList;

                lblTotalRows.Text = modelList.Count.ToString();
            }
            catch (Exception x)
            {

            }
        }

        private void dgReceivableAmt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
