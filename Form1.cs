using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarzoneCalculator
{
	public partial class CalculatorForm : Form
	{

		Point dragStart = new Point(0, 0);

		bool dragging = false;

		bool attackingCommander = false;
		bool defendingCommander = false;
		int attackingArmies = 0;
		int defendingArmies = 0;

		int attackKills = 0;
		int defendKills = 0;

		bool destroyedAllDefenders = false;
		bool destroyedAllAttackers = false;

		int attackingArmiesLost = 0;
		int defendingArmiesLost = 0;

		public CalculatorForm()
		{
			InitializeComponent();
		}

		private void TopBar_MouseDown(object sender, MouseEventArgs e)
		{
			dragStart = e.Location;
			dragging = true;
		}

		private void TopBar_MouseMove(object sender, MouseEventArgs e)
		{
			if (dragging)
			{
				var dx = (e.X - dragStart.X);
				var dy = (e.Y - dragStart.Y);
				this.Location = new Point(this.Location.X + dx, this.Location.Y + dy);
			}
		}

		private void TopBar_MouseUp(object sender, MouseEventArgs e)
		{
			dragging = false;
		}

		private void CloseLabel_MouseUp(object sender, MouseEventArgs e)
		{
			System.Windows.Forms.Application.ExitThread();
		}

		private void CalculateLosses()
		{
			attackingArmiesLost = Math.Min(defendKills, attackingArmies);
			defendingArmiesLost = Math.Min(attackKills, defendingArmies);

			AttackLoss.Text = "-" + attackingArmiesLost;
			DefendLoss.Text = "-" + defendingArmiesLost;

			OutcomeAttackAmount.Text = (attackingArmies - attackingArmiesLost).ToString();
			OutcomeDefendAmount.Text = (defendingArmies - defendingArmiesLost).ToString();

			var attackingCommanderAlive = (attackingCommander && defendKills - attackingArmies < 7);
			var defendingCommanderAlive = (defendingCommander && attackKills - defendingArmies < 7);

			CommanderAttackOutcome.Checked = attackingCommanderAlive;
			CommanderDefendOutcome.Checked = defendingCommanderAlive;

			destroyedAllAttackers = (attackingArmies == attackingArmiesLost && !attackingCommanderAlive);
			destroyedAllDefenders = (defendingArmies == defendingArmiesLost && !defendingCommanderAlive);
		}

		private void CalculateAttack()
		{
			var armies = AttackArmies.Value;
			var rate = OffensiveRate.Value;
			var commander = AttackCommanderCheck.Checked;

			attackingArmies = (int) armies;

			// Set attack preview amount
			PreviewAttackAmount.Text = armies.ToString();

			if (commander) armies += 7;

			attackKills = (int) Math.Round(armies * rate, 0);
			AttackResult.Text = attackKills.ToString();

			CalculateLosses();
		}

		private void AttackArmies_ValueChanged(object sender, EventArgs e)
		{
			CalculateAttack();

			OutcomePanel.BackColor = Color.FromArgb(27, 27, 27);
		}

		private void AttackCommanderCheck_CheckedChanged(object sender, EventArgs e)
		{
			attackingCommander = ((CheckBox)sender).Checked;

			CommanderAttackPreview.Checked = ((CheckBox)sender).Checked;

			CalculateAttack();

			OutcomePanel.BackColor = Color.FromArgb(27, 27, 27);
		}

		private void OffensiveRate_ValueChanged(object sender, EventArgs e)
		{
			CalculateAttack();

			OutcomePanel.BackColor = Color.FromArgb(27, 27, 27);
		}

		private void CalculateDefense()
		{
			var armies = DefenseArmies.Value;
			var rate = DefensiveRate.Value;
			var commander = DefendCommanderCheck.Checked;

			defendingArmies = (int) armies;

			// Set defense preview amount
			PreviewDefendAmount.Text = armies.ToString();

			if (commander) armies += 7;

			defendKills = (int) Math.Round(armies * rate, 0);
			DefenseResult.Text = defendKills.ToString();

			CalculateLosses();
		}

		private void DefenseArmies_ValueChanged(object sender, EventArgs e)
		{
			CalculateDefense();

			OutcomePanel.BackColor = Color.FromArgb(27, 27, 27);
		}

		private void DefendCommanderCheck_CheckedChanged(object sender, EventArgs e)
		{
			defendingCommander = ((CheckBox)sender).Checked;

			CommanderDefendPreview.Checked = ((CheckBox) sender).Checked;

			CalculateDefense();

			OutcomePanel.BackColor = Color.FromArgb(27, 27, 27);
		}

		private void DefensiveRate_ValueChanged(object sender, EventArgs e)
		{
			CalculateDefense();

			OutcomePanel.BackColor = Color.FromArgb(27, 27, 27);
		}

		private void DefendButton_Click(object sender, EventArgs e)
		{
			CalculateLosses();

			if (destroyedAllDefenders && !destroyedAllAttackers) OutcomePanel.BackColor = Color.Red;
			else if (attackingArmiesLost < defendingArmiesLost) OutcomePanel.BackColor = Color.Orange;
			else OutcomePanel.BackColor = Color.Green;
		}

		private void AttackButton_Click(object sender, EventArgs e)
		{
			CalculateLosses();

			if (destroyedAllAttackers) OutcomePanel.BackColor = Color.Red;
			else if (destroyedAllDefenders) OutcomePanel.BackColor = Color.Green;
			else if (attackingArmiesLost < defendingArmiesLost) OutcomePanel.BackColor = Color.YellowGreen;
			else if (attackingArmiesLost == defendingArmiesLost) OutcomePanel.BackColor = Color.FromArgb(127, 127, 0);
			else if (attackingArmiesLost > defendingArmiesLost) OutcomePanel.BackColor = Color.Orange;
		}
	}
}
