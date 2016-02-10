# EncodingPerfTests

## Why?

Because I wanted to see how much of a performance impact adding a call to Enconding.UTF8.GetByteCount would have on my software.

## What?

This application simply times the execution of calls to methods on encoders. It runs the following tests:

* UTF8
  * GetByteCount
    * With 1K characters x1M
    * With 10K characters x1M
    * With 100K characters x100K
    * With 500K characters x100K
  * GetBytes
    * With 1K characters x1M
    * With 10K characters x1M
    * With 100K characters x100K
    * With 500K characters x100K

## Sample Output

On my under-resourced VM I received the following output -

    GetByteCount Tests

    Test: GetByteCount with 1K character values
    Iterations: 1000000
    Execution Time: 00:00:00.7067152
    Avg Time/Iteration (ms): 0.000706

    Test: GetByteCount with 10K character values
    Iterations: 1000000
    Execution Time: 00:00:06.6350705
    Avg Time/Iteration (ms): 0.006635

    Test: GetByteCount with 100K character values
    Iterations: 100000
    Execution Time: 00:00:06.5234639
    Avg Time/Iteration (ms): 0.06523

    Test: GetByteCount with 500K character values
    Iterations: 100000
    Execution Time: 00:00:32.9015421
    Avg Time/Iteration (ms): 0.32901

    GetBytes Tests

    Test: GetBytes with 1K character values
    Iterations: 1000000
    Execution Time: 00:00:01.4848552
    Avg Time/Iteration (ms): 0.001484

    Test: GetBytes with 10K character values
    Iterations: 1000000
    Execution Time: 00:00:14.1967789
    Avg Time/Iteration (ms): 0.014196

    Test: GetBytes with 100K character values
    Iterations: 100000
    Execution Time: 00:00:16.2303076
    Avg Time/Iteration (ms): 0.1623

    Test: GetBytes with 500K character values
    Iterations: 100000
    Execution Time: 00:01:30.3881462
    Avg Time/Iteration (ms): 0.90388

    Total Execution Time: 00:02:49.1493478
