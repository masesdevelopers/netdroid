/*
 *  Copyright 2024 MASES s.r.l.
 *
 *  Licensed under the Apache License, Version 2.0 (the "License");
 *  you may not use this file except in compliance with the License.
 *  You may obtain a copy of the License at
 *
 *  http://www.apache.org/licenses/LICENSE-2.0
 *
 *  Unless required by applicable law or agreed to in writing, software
 *  distributed under the License is distributed on an "AS IS" BASIS,
 *  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *  See the License for the specific language governing permissions and
 *  limitations under the License.
 *
 *  Refer to LICENSE for more information.
 */

package org.mases.netdroid.developed.java.util.function;

import org.mases.jcobridge.*;

/**
 * The {@link BiConsumer} class represents a generic implementation of
 * {@link java.util.function.BiConsumer}
 */
public final class BiConsumer extends JCListener implements java.util.function.BiConsumer {
    public BiConsumer(String key) throws JCNativeException {
        super(key);
    }

    @Override
    public void accept(Object e1, Object e2) {
        raiseEvent("accept", e1, e2);
    }
}