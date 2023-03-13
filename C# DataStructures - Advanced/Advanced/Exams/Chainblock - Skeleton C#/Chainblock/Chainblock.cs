using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Wintellect.PowerCollections;

public class Chainblock : IChainblock
{
    private Dictionary<int, Transaction> transactions;
    private Dictionary<TransactionStatus, Dictionary<int, Transaction>> txByStatus;

    public Chainblock()
    {
        this.transactions = new Dictionary<int, Transaction>();
        this.txByStatus = new Dictionary<TransactionStatus, Dictionary<int, Transaction>>();
    }

    public int Count => this.transactions.Count;

    public void Add(Transaction tx)
    {
        this.transactions.Add(tx.Id, tx);

        if (!this.txByStatus.ContainsKey(tx.Status))
        {
            this.txByStatus.Add(tx.Status, new Dictionary<int, Transaction>());
        }
        if (!this.txByStatus[tx.Status].ContainsKey(tx.Id))
        {
            this.txByStatus[tx.Status].Add(tx.Id, tx);
        }
        this.txByStatus[tx.Status][tx.Id] = tx;
    }

    public void ChangeTransactionStatus(int id, TransactionStatus newStatus)
    {
        if (!this.transactions.ContainsKey(id))
        {
            throw new ArgumentException();
        }
        var temp = this.transactions[id];
        this.txByStatus[temp.Status].Remove(temp.Id);
        temp.Status = newStatus;

        if (!this.txByStatus.ContainsKey(newStatus))
        {
            this.txByStatus.Add(newStatus, new Dictionary<int, Transaction>());
        }

        this.txByStatus[newStatus][temp.Id] = temp;
    }

    public bool Contains(Transaction tx)
    {
        return this.Contains(tx.Id);
    }

    public bool Contains(int id)
    {
        return this.transactions.ContainsKey(id);
    }

    public IEnumerable<Transaction> GetAllInAmountRange(double lo, double hi)
    {
        return this.transactions.Values.Where(t => t.Amount >= lo && t.Amount <= hi);
    }

    public IEnumerable<Transaction> GetAllOrderedByAmountDescendingThenById()
    {
        return this.transactions.Values
             .OrderByDescending(t => t.Amount)
             .ThenBy(t => t.Id);
    }

    public IEnumerable<string> GetAllReceiversWithTransactionStatus(TransactionStatus status)
    {
        if (this.txByStatus.ContainsKey(status))
        {
            var receivers = this.txByStatus[status].Values.Select(t => t.To).ToList();
            if (receivers.Count !=0)
            {
                return receivers;
            }
        }

        throw new InvalidOperationException();
    }

    public IEnumerable<string> GetAllSendersWithTransactionStatus(TransactionStatus status)
    {
        if (this.txByStatus.ContainsKey(status))
        {
           var senders = this.txByStatus[status].Values.Select(t => t.From).ToList();

            if (senders.Count != 0)
            {
                return senders;
            }
        }

        throw new InvalidOperationException();
    }

    public Transaction GetById(int id)
    {
        if (!this.transactions.ContainsKey(id))
        {
            throw new InvalidOperationException();
        }

        return this.transactions[id];
    }

    public IEnumerable<Transaction> GetByReceiverAndAmountRange(string receiver, double lo, double hi)
    {
        var txs = this.transactions.Values
            .Where(t => t.To == receiver
                  && t.Amount >= lo && t.Amount < hi)
            .OrderByDescending(t => t.Amount)
            .ThenBy(t => t.Id);

        if (txs == null || txs.Count() == 0)
        {
            throw new InvalidOperationException();
        }

        return txs;
    }

    public IEnumerable<Transaction> GetByReceiverOrderedByAmountThenById(string receiver)
    {
        var txs = this.transactions.Values
            .Where(t => t.To == receiver)
            .OrderByDescending(t => t.Amount)
            .ThenBy(t => t.Id);

        if (txs == null || txs.Count() == 0)
        {
            throw new InvalidOperationException();
        }

        return txs;
    }

    public IEnumerable<Transaction> GetBySenderAndMinimumAmountDescending(string sender, double amount)
    {
        var txs = this.transactions.Values
            .Where(t => t.From == sender && t.Amount > amount)
            .OrderByDescending(t => t.Amount);

        if (txs == null || txs.Count() == 0)
        {
            throw new InvalidOperationException();
        }

        return txs;
    }

    public IEnumerable<Transaction> GetBySenderOrderedByAmountDescending(string sender)
    {
        var txs = this.transactions.Values
            .Where(t => t.From == sender)
            .OrderByDescending(t => t.Amount);

        if (txs == null || txs.Count() == 0)
        {
            throw new InvalidOperationException();
        }

        return txs;
    }

    public IEnumerable<Transaction> GetByTransactionStatus(TransactionStatus status)
    {
        if (!this.txByStatus.ContainsKey(status))
        {
            throw new InvalidOperationException();
        }

        return this.txByStatus[status].Values.OrderByDescending(t => t.Amount);
    }

    public IEnumerable<Transaction> GetByTransactionStatusAndMaximumAmount(TransactionStatus status, double amount)
    {
        if (!this.txByStatus.ContainsKey(status))
        {
            return new List<Transaction>();
        }

        return this.txByStatus[status].Values
             .Where(t => t.Amount <= amount)
             .OrderByDescending(t => t.Amount)
             .ToList();
    }

    public void RemoveTransactionById(int id)
    {
        if (!this.transactions.ContainsKey(id))
        {
            throw new InvalidOperationException();
        }
        var tx = this.transactions[id];
        this.txByStatus[tx.Status].Remove(tx.Id);
        this.transactions.Remove(id);
    }

    public IEnumerator<Transaction> GetEnumerator()
    {
        foreach (var tx in this.transactions)
        {
            yield return tx.Value;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
        => this.GetEnumerator();
}

